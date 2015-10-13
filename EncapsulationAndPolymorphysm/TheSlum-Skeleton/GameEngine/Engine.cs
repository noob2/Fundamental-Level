namespace TheSlum.GameEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;
    using characters;
    using items;

    public class Engine
    {
        protected List<Character> characterList = new List<Character>();
        protected List<Bonus> timeoutItems;

        private const int GameTurns = 6;

        public virtual void Run()
        {
            this.ReadUserInput();
            this.InitializeTimeoutItems();

            for (int i = 0; i < GameTurns; i++)
            {
                foreach (var character in this.characterList)
                {
                    if (character.IsAlive)
                    {
                        this.ProcessTargetSearch(character);
                    }
                }

                this.ProcessItemTimeout(this.timeoutItems);
            }

            this.PrintGameOutcome();
        }

        public void ProcessItemTimeout(List<Bonus> timeoutItems)
        {
            for (int i = 0; i < timeoutItems.Count; i++)
            {
                timeoutItems[i].Countdown--;
                if (timeoutItems[i].Countdown == 0)
                {
                    var item = timeoutItems[i];
                    item.HasTimedOut = true;
                    var itemHolder = this.GetCharacterByItem(item);
                    itemHolder.RemoveFromInventory(item);
                    i--;
                }
            }
        }

        public void InitializeTimeoutItems()
        {
            this.timeoutItems = this.characterList.SelectMany(c => c.Inventory).Where(i => i is Bonus).Cast<Bonus>().ToList();
        }

        protected virtual void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create": CreateCharacter(inputParams);
                    break;

                case "add": AddItem(inputParams);
                    break;

                default: ExecuteCommand(inputParams);
                    break;
            }
        }

        protected virtual void CreateCharacter(string[] inputParams)
        {
            Character newCharacter;
            switch (inputParams[1].ToLower())
            {
                case "warrior":
                    newCharacter = new Warrior(inputParams[2],int.Parse(inputParams[3]),int.Parse(inputParams[4]),200,100,150,(Team)Enum.Parse(typeof(Team), inputParams[5], true),2);
                    this.characterList.Add(newCharacter);
                    break;

                case "mage":
                    newCharacter = new Mage(inputParams[2],int.Parse(inputParams[3]),int.Parse(inputParams[4]),150,50,300,(Team)Enum.Parse(typeof(Team), inputParams[5], true),5);
                    this.characterList.Add(newCharacter);
                    break;

                case "healer":
                    newCharacter = new Healer(inputParams[2],int.Parse(inputParams[3]),int.Parse(inputParams[4]),75,50,60,(Team)Enum.Parse(typeof(Team), inputParams[5], true),6);
                    this.characterList.Add(newCharacter);
                    break;
                default:
                    break;
            }
        }

        protected void AddItem(string[] inputParams)
        {
            Character characterToAcceptIitem = GetCharacterById(inputParams[1]);
            Item itemToAdd;
            switch (inputParams[2])
            {
                case "axe":
                    itemToAdd = new Axe(inputParams[3]);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                case "shield":
                    itemToAdd = new Shield(inputParams[3]);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                case "injection":
                    itemToAdd = new Injection(inputParams[3]);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                case "pill":
                    itemToAdd = new Pill(inputParams[3]);
                    characterToAcceptIitem.AddToInventory(itemToAdd);
                    break;
                default:
                    break;
            }
        }

        protected void ProcessTargetSearch(Character currentCharacter)
        {
            var availableTargets = this.characterList
                .Where(t => this.IsWithinRange(currentCharacter.X, currentCharacter.Y, t.X, t.Y, currentCharacter.Range))
                .ToList();

            if (availableTargets.Count == 0)
            {
                return;
            }

            var target = currentCharacter.GetTarget(availableTargets);
            if (target == null)
            {
                return;
            }

            this.ProcessInteraction(currentCharacter, target);
        }

        protected void ProcessInteraction(Character currentCharacter, Character target)
        {
            if (currentCharacter is IHeal)
            {
                target.HealthPoints += (currentCharacter as IHeal).HealingPoints;
            }
            else if (currentCharacter is IAttack)
            {
                target.HealthPoints -= (currentCharacter as IAttack).AttackPoints - target.DefensePoints;
                if (target.HealthPoints <= 0)
                {
                    target.IsAlive = false;
                }
            }
        }

        protected bool IsWithinRange(int attackerX, int attackerY, int targetX, int targetY, int range)
        {
            double distance = Math.Sqrt(
                (attackerX - targetX) * (attackerX - targetX) +
                (attackerY - targetY) * (attackerY - targetY));

            return distance <= range;
        }

        protected Character GetCharacterById(string characterId)
        {
            return this.characterList.FirstOrDefault(x => x.Id == characterId);
        }

        protected Character GetCharacterByItem(Item item)
        {
            return this.characterList.FirstOrDefault(x => x.Inventory.Contains(item));
        }

        protected void PrintCharactersStatus(IEnumerable<Character> characters)
        {
            foreach (var character in characters)
            {
                Console.WriteLine(character.ToString());
            }
        }

        protected void PrintGameOutcome()
        {
            var charactersAlive = this.characterList.Where(c => c.IsAlive);
            var redTeamCount = charactersAlive.Count(x => x.Team == Team.Red);
            var blueTeamCount = charactersAlive.Count(x => x.Team == Team.Blue);

            if (redTeamCount == blueTeamCount)
            {
                Console.WriteLine("Tie game!");
            }
            else
            {
                string winningTeam = redTeamCount > blueTeamCount ? "Red" : "Blue";
                Console.WriteLine(winningTeam + " team wins the game!");
            }

            var aliveCharacters = this.characterList.Where(c => c.IsAlive);
            this.PrintCharactersStatus(aliveCharacters);
        }

        private void ReadUserInput()
        {
            string inputLine = Console.ReadLine();
            while (inputLine != string.Empty)
            {
                string[] parameters = inputLine
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                this.ExecuteCommand(parameters);
                inputLine = Console.ReadLine();
            }
        }
    }
}
