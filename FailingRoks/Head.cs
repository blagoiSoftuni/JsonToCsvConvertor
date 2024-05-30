using FailingRoks;
using System.Numerics;

namespace FailingRoks
{
    internal class Head 
    {


        static void Main(string[] args)
        {



            SetWindowProperties();
            Console.CursorVisible = false;


            Player Player = new Player(Console.WindowWidth / 2, Console.WindowHeight - 1);


            List<Rock> rocks = new List<Rock>();
            List<Rock> rocksToRemove = new List<Rock>();


            int spawnRate = ProcessPlayerRocksSpawnRateChoice("Enter rocks spawn rate (1-10): ");


            int fallSpeed = ProcessPlayerRockFallSpeedChoice("Enter rocks fall speed (1-10): ");
            int points = 0;
            while (true)
            {
                RedrawConsole(points);
                Player.Draw();
                Player.Move();


                if (ShouldGenerateRock(spawnRate))
                {
                    CreateRocks(rocks);
                }


                DrawRocks(rocks);
                MoveRocks(rocks, fallSpeed);


                foreach (Rock rock in rocks)
                {
                    if (ThereIsCollision(rock, Player))
                    {
                        Player.HasBeenHit = true;
                        EndGame(points);
                    }
                }


                RemoveRocks(rocksToRemove, rocks, Player);

                rocksToRemove.Clear();

                Thread.Sleep(50);
            }

            static void SetWindowProperties()
            {
                Console.Title = "Rock Dodger";
                Console.WindowWidth = 50;
                Console.WindowHeight = 20;
                Console.BufferWidth = Console.WindowWidth;
                Console.BufferHeight = Console.WindowHeight;
            }

            static void RedrawConsole(int points)
            {
                Console.Clear();
                DrawScorePanel(points);

            }

            static void DrawScorePanel(int points)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Score:" + points);
            }

            static int ProcessPlayerRocksSpawnRateChoice(string inputSpawnRate)
            {
                int spawnRate;
                do
                {
                    Console.Write(inputSpawnRate);
                } while (!int.TryParse(Console.ReadLine(), out spawnRate) || spawnRate < 1 || spawnRate > 10);

                return spawnRate;
            }

            static int ProcessPlayerRockFallSpeedChoice(string inputFallSpeed)
            {
                int fallSpeed;
                do
                {
                    Console.Write(inputFallSpeed);
                } while (!int.TryParse(Console.ReadLine(), out fallSpeed) || fallSpeed < 1 || fallSpeed > 10);

                return fallSpeed;
            }

            static void CreateRocks(List<Rock> rocks)
            {
                Random random = new Random();
                int rockX = random.Next(Console.WindowWidth);
                Rock rock = new Rock(rockX);
                rocks.Add(rock);
            }

            static bool ShouldGenerateRock(int spawnRate)
            {
                return new Random().Next(11 - spawnRate) == 0;
            }

            static void DrawRocks(List<Rock> rocks)
            {
                foreach (Rock rock in rocks)
                {
                    Console.SetCursorPosition(rock.X, rock.Y);
                    Console.Write(rock.Symbol);
                }
            }

            static void MoveRocks(List<Rock> rocks, int fallSpeed)
            {
                foreach (Rock rock in rocks)
                {
                    rock.Y += fallSpeed;
                }
            }

            static bool ThereIsCollision(Rock rock, Player player)
            {
                return RockAndPlayerAreOnSameWidth(rock, player) && RockAndPlayerAreOnSameHeight(rock, player);
            }

            static bool RockAndPlayerAreOnSameWidth(Rock rock, Player player)
            {
                return rock.X == player.X;
            }

            static bool RockAndPlayerAreOnSameHeight(Rock rock, Player player)
            {
                return rock.Y == player.Y;
            }

            static void RemoveRocks(List<Rock> rocksToRemove, List<Rock> rocks, Player player)
            {
                foreach (Rock rock in rocks)
                {
                    if (rock.Y >= Console.WindowHeight - 1)
                    {
                        rocksToRemove.Add(rock);
                    }
                }

                foreach (Rock rockToRemove in rocksToRemove)
                {
                    rocks.Remove(rockToRemove);
                }
            }

            static void EndGame(int points)
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.Write("Game Over!");
                Environment.Exit(0);
            }

        }
    }
}
    
