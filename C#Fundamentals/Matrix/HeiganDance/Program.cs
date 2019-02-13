using System;

namespace HeiganDance
{
    public class Program
    {
        static int playerRow = 7;
        static int playerCol = 7;

        static int plague = 3500;
        static int eruption = 6000;

        static int playerLifePoints = 18500;
        static double heiganLifePoints = 3000000;

        static bool isPlagueCloud = false;
        static string lastSpell = "";
        public static void Main(string[] args)
        {
            double playerDmg = double.Parse(Console.ReadLine());


            while (true)
            {
                if (playerLifePoints > 0)
                {
                    heiganLifePoints -= playerDmg;
                }
                if (playerLifePoints <= 0 || heiganLifePoints <= 0)
                {
                    break;
                }
                if (isPlagueCloud)
                {
                    playerLifePoints -= plague;
                    isPlagueCloud = false;
                }

                var input = Console.ReadLine().Split();
                var magic = input[0];
                var targetRow = int.Parse(input[1]);
                var targetCol = int.Parse(input[2]);

                if (!IsInAttackArea(playerRow, playerCol, targetCol, targetRow))
                {
                    continue;
                }
                bool canMoveUp = !IsInAttackArea(playerRow - 1, playerCol, targetRow, targetCol) && IsInside(playerRow - 1);
                bool canMoveRight = !IsInAttackArea(playerRow, playerCol + 1, targetRow, targetCol) && IsInside(playerCol + 1);
                bool canMoveDown = !IsInAttackArea(playerRow + 1, playerCol, targetRow, targetCol) && IsInside(playerRow + 1);
                bool canMoveLeft = !IsInAttackArea(playerRow, playerCol - 1, targetRow, targetCol) && IsInside(playerCol - 1);
                if (canMoveUp)
                {
                    playerRow--;
                    continue;
                }
                if (canMoveRight)
                {
                    playerCol++;
                    continue;
                }
                if (canMoveDown)
                {
                    playerRow++;
                    continue;
                }
                if (canMoveLeft)
                {
                    playerCol--;
                    continue;
                }
                if (magic == "Cloud")
                {
                    playerLifePoints -= plague;
                    isPlagueCloud = true;
                    lastSpell = "Plague Cloud";
                }
                if (magic == "Eruption")
                {
                    playerLifePoints -= eruption;
                    lastSpell = "Eruption";
                }

            }
            if (heiganLifePoints <= 0)
            {
                Console.WriteLine("Heigan: Defeated!");
            }
            else
            {
                Console.WriteLine($"Heigan: {heiganLifePoints:f2}");
            }
            if (playerLifePoints <= 0)
            {
                Console.WriteLine($"Player: Killed by {lastSpell}");
            }
            else
            {
                Console.WriteLine($"Player: { playerLifePoints}");
            }
            Console.WriteLine($"Final position: {playerRow}, {playerCol}");
        }


        private static bool IsInside(int rcIndex)
        {
            return rcIndex >= 0 && rcIndex < 15;
        }

        private static bool IsInAttackArea(int playerRow, int playerCol, int targetCol, int targetRow)
        {
            return playerRow >= targetRow - 1 && playerRow <= targetRow + 1 &&
                playerCol >= targetCol - 1 && playerCol <= targetCol + 1;
        }




    }
}
