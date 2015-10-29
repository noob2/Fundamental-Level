using IgraNaMe4ove.GameObject;
using IgraNaMe4ove.GameObject.characters;
using IgraNaMe4ove.GameObject.enemy;
using System;
using System.Collections.Generic;

namespace IgraNaMe4ove
{
    public class GameEngine
    {
        public const int rowSize = 50;
        public const int colSize = 40;
        public const int wallsDencity = 200;
        public const int enemyCount = 10;

        List<GameObject.GameObject> gameObjects = new List<GameObject.GameObject>();
        List<Enemy> enemiesOnMap = new List<Enemy>();

        character champion;

        public void run()
        {
            GenerateWalls(wallsDencity);

            GenerateEnemy(enemyCount);

            champion = SelectCharacter();

            while (true)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey();

                if (keyPressed.Key == ConsoleKey.DownArrow)
                {
                    MoveDown();
                }
                else if(keyPressed.Key == ConsoleKey.UpArrow)
                {
                    MoveUp();
                }
                else if (keyPressed.Key == ConsoleKey.RightArrow)
                {
                    MoveRight();
                }
                else if (keyPressed.Key == ConsoleKey.LeftArrow)
                {
                    MoveLeft();
                }
                else if (keyPressed.Key == ConsoleKey.S)
                {
                    MarkTargetAndAttac();
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
                Console.SetCursorPosition(colSize + 5, 11);
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

        public character SelectCharacter()
        {
            Console.Clear();

            Random randomNumber = new Random();
            while (true)
            {
                int x = randomNumber.Next(rowSize);
                int y = randomNumber.Next(colSize);

                bool isFreePlace = true;
                foreach (var gameObject in gameObjects)
                {
                    if (gameObject.X == x && gameObject.Y == y)
                    {
                        isFreePlace = false;
                        break;
                    }
                }
                foreach (var gameObject in enemiesOnMap)
                {
                    if (gameObject.X == x && gameObject.Y == y)
                    {
                        isFreePlace = false;
                        break;
                    }
                }

                if (isFreePlace)
                {
                    while (true)
                    {

                        Console.Write("Please select character :\n 'M' for mage\n 'W' for warrior\n 'A' for archer \n");

                        ConsoleKeyInfo key = Console.ReadKey();

                        character champion;

                        if (key.Key == ConsoleKey.M)
                        {
                            champion = new Mage(x, y);
                            return champion;
                        }
                        else if (key.Key == ConsoleKey.W)
                        {
                            champion = new Warrior(x, y);
                            return champion;
                        }
                        else if (key.Key == ConsoleKey.A)
                        {
                            champion = new Archer(x, y);
                            return champion;
                        }
                        Console.Clear();
                        Console.WriteLine("are you stuped ?? try again");
                    }
                }
            }

            
        }

        public void MoveDown()
        {
            if (champion.X+1 < rowSize)
            {
                bool canItMove = true;
                foreach (var gameObject in gameObjects)
                {
                    if (gameObject.Y == champion.Y && gameObject.X == champion.X + 1 && gameObject.Symbol == '+')
                    {
                        canItMove = false;
                        break;
                    }
                }

                if (canItMove)
                {
                    champion.X++;
                }
            }
        }

        public void MoveUp()
        {
            if (champion.X  > 0)
            {
                bool canItMove = true;
                foreach (var gameObject in gameObjects)
                {
                    if (gameObject.Y == champion.Y && gameObject.X == champion.X - 1 && gameObject.Symbol == '+')
                    {
                        canItMove = false;
                        break;
                    }
                }

                if (canItMove)
                {
                    champion.X--;
                }
            }
        }

        public void MoveRight()
        {
            if (champion.Y + 1 < colSize)
            {
                bool canItMove = true;

                foreach (var gameObject in gameObjects)
                {
                    if (gameObject.X == champion.X && gameObject.Y == champion.Y + 1 && gameObject.Symbol == '+')
                    {
                        canItMove = false;
                        break;
                    }
                }

                if (canItMove)
                {
                    champion.Y++;
                }
            }
        }

        public void MoveLeft()
        {
            if (champion.Y > 0)
            {
                bool canItMove = true;

                foreach (var gameObject in gameObjects)
                {
                    if (gameObject.X == champion.X && gameObject.Y == champion.Y - 1 && gameObject.Symbol == '+')
                    {
                        canItMove = false;
                        break;
                    }
                }

                if (canItMove)
                {
                    champion.Y--;
                }
            }
        }

        public void GenerateWalls(int dencity)
        {
            Random randomNumber = new Random();

            for (int i = 0; i < dencity; i++)
            {
                gameObjects.Add(new Wall(randomNumber.Next(rowSize), randomNumber.Next(colSize)));
            }
        }

        public void GenerateEnemy(int dencity)
        {
            Random randomNumber = new Random();

            for (int i = 0; i < dencity; i++)
            {
                int x = randomNumber.Next(rowSize);
                int y = randomNumber.Next(colSize);

                bool isFreePlace = true;
                foreach (var gameObject in gameObjects)
                {
                    if (gameObject.X == x && gameObject.Y == y)
                    {
                        isFreePlace = false;
                        break;
                    }
                }

                if (isFreePlace)
                {
                    enemiesOnMap.Add(new Wolf(x,y));
                }
                else
                {
                    i--;
                }
            }
        }

        public void DrawMap()
        {
            Console.Clear();
            Console.ResetColor();

            Console.SetCursorPosition(2, rowSize + 1);
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
            Console.SetCursorPosition(colSize + 5, 1);
            Console.Write("Health : {0}", champion.Health);
            Console.SetCursorPosition(colSize + 5, 3);
            Console.Write("Mana   : {0}", champion.Mana);
            Console.SetCursorPosition(colSize + 5, 5);
            Console.Write("Range  : {0}", champion.Range);
            Console.SetCursorPosition(colSize + 5, 7);
            Console.Write("Damage : {0}", champion.AttackDamage);
            Console.ResetColor();
        }

        public void DrawEnemyStatus(Enemy enemy)
        {
            Console.SetCursorPosition(colSize + 5, 11);
            Console.Write("Health : {0}", enemy.Health);
            Console.SetCursorPosition(colSize + 5, 13);
            Console.Write("Range  : {0}", enemy.Range);
            Console.SetCursorPosition(colSize + 5, 15);
            Console.Write("Damage : {0}", enemy.AttackDamage);
            Console.ResetColor();
        }
    }
}
