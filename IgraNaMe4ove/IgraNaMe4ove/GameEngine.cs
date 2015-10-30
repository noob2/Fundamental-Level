using IgraNaMe4ove.GameObject;
using IgraNaMe4ove.GameObject.characters;
using IgraNaMe4ove.GameObject.enemy;
using System;
using System.Collections.Generic;

namespace IgraNaMe4ove
{
    public class GameEngine
    {
        public const int MapHeight = 10;
        public const int MapWidth = 40;
        public const int wallsCount = 2;
        public const int enemyCount = 10;

        private static readonly Random Random = new Random();

        List<GameObject.GameObject> gameObjects = new List<GameObject.GameObject>();
        List<Enemy> enemiesOnMap = new List<Enemy>();
        character champion;

        public void run()
        {
            GenerateWalls();

            GenerateEnemy();

            SelectCharacter();
            DrawMap();
            while (true)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.LeftArrow:
                        champion.Move(keyPressed);
                        break;
                    case ConsoleKey.S:
                        MarkTargetAndAttac();
                        break;
                    default:
                        throw new ArgumentException("Invalid key.", "key");
                }
                DrawMap();
            }
        }

        public void MarkTargetAndAttac()
        {
            bool targetFound = false;
            for (int i = 0; i < enemiesOnMap.Count; i++)
            {
                if (IsInRange(enemiesOnMap[i]))
                {
                    targetFound = true;
                    DrawMap();

                    Console.SetCursorPosition(enemiesOnMap[i].Y, enemiesOnMap[i].X);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(enemiesOnMap[i].Symbol);

                    DrawEnemyStatus(enemiesOnMap[i]);
                    Console.ResetColor();

                    ConsoleKeyInfo keyPressed = Console.ReadKey();

                    if (keyPressed.Key == ConsoleKey.A)
                    {
                        if (enemiesOnMap[i].Health > champion.AttackDamage)
                        {
                            champion.Attack(enemiesOnMap[i]);
                        }
                        else
                        {
                            enemiesOnMap.RemoveAt(i);
                        }
                        break;
                    }
                }
            }
            if (targetFound)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(MapWidth + 5, 11);
                Console.Write("No Tragets found !");
                Console.ReadKey();
            }
        }

        public bool IsInRange(GameObject.GameObject enemy)
        {
            if (Math.Abs(enemy.X - champion.X) <= champion.Range && Math.Abs(enemy.Y - champion.Y) <= champion.Range)
            {
                return true;
            }
            return false;
        }

        public bool IsFreePlace(int x,int y)
        {
            foreach (var gameObject in gameObjects)
            {
                if (gameObject.X == x && gameObject.Y == y)
                {
                    return false;
                }
            }
            return true;
        }

        public void SelectCharacter()
        {
            Console.Clear();

            while (true)
            {
                int x = Random.Next(MapHeight);
                int y = Random.Next(MapWidth);

                if (IsFreePlace(x,y))
                {
                    while (true)
                    {

                        Console.Write("Please select character :\n 'M' for mage\n 'W' for warrior\n 'A' for archer \n");

                        ConsoleKeyInfo selector = Console.ReadKey();

                        switch (selector.Key)
                        {
                            case ConsoleKey.M:
                                champion = new Mage(x, y);
                                return;
                            case ConsoleKey.W:
                                champion = new Warrior(x, y);
                                return;
                            case ConsoleKey.A:
                                champion = new Archer(x, y);
                                return;
                        }
                        Console.Clear();
                        Console.WriteLine("are you stuped ?? try again");
                    }
                }
            }

            
        }

        public void GenerateWalls()
        {
            int wallsLeft = wallsCount;

            while (wallsLeft > 0)
            {
                int x = Random.Next(MapHeight);
                int y = Random.Next(MapWidth);

                if (IsFreePlace(x, y))
                {
                    gameObjects.Add(new Wall(x, y));
                    wallsLeft--;
                }
            }
        }

        public void GenerateEnemy()
        {
            int enemyLeft = enemyCount;

            while (enemyLeft > 0)
            {
                int x = Random.Next(MapHeight);
                int y = Random.Next(MapWidth);

                if (IsFreePlace(x, y))
                {
                    gameObjects.Add(new Wolf(x, y));
                    enemyLeft--;
                }
            }
        }

        public void DrawMap()
        {
            Console.Clear();
            Console.ResetColor();

            Console.SetCursorPosition(2, MapHeight + 1);
            Console.Write("press S, to select target, A to attack, Arrows to Move");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            foreach (var something in gameObjects)
            {
                Console.SetCursorPosition(something.Y, something.X);
                Console.Write(something.Symbol);
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (var something in enemiesOnMap)
            {
                Console.SetCursorPosition(something.Y, something.X);
                Console.Write(something.Symbol);
            }

            Console.SetCursorPosition(champion.Y, champion.X);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(champion.Symbol);
            Console.ResetColor();

            DrawPlayerStatus();
        }

        public void DrawPlayerStatus()
        {
            Console.SetCursorPosition(MapWidth + 5, 1);
            Console.Write("Health : {0}", champion.Health);
            Console.SetCursorPosition(MapWidth + 5, 3);
            Console.Write("Mana   : {0}", champion.Mana);
            Console.SetCursorPosition(MapWidth + 5, 5);
            Console.Write("Range  : {0}", champion.Range);
            Console.SetCursorPosition(MapWidth + 5, 7);
            Console.Write("Damage : {0}", champion.AttackDamage);
            Console.ResetColor();
        }

        public void DrawEnemyStatus(Enemy enemy)
        {
            Console.SetCursorPosition(MapWidth + 5, 11);
            Console.Write("Health : {0}", enemy.Health);
            Console.SetCursorPosition(MapWidth + 5, 13);
            Console.Write("Range  : {0}", enemy.Range);
            Console.SetCursorPosition(MapWidth + 5, 15);
            Console.Write("Damage : {0}", enemy.AttackDamage);
            Console.ResetColor();
        }
    }
}
// predi be6e 350 reda kod