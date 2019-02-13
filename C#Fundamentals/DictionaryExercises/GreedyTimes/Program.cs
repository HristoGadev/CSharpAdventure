using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedyTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            long bagCapacity = long.Parse(Console.ReadLine());

            var input = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string, long> cashes = new Dictionary<string, long>();
            Dictionary<string, long> gems = new Dictionary<string, long>();
            Dictionary<string, long> gold = new Dictionary<string, long>();

            var currenceName = "";
            long currenceAmmount = 0;
            long sumGem = 0;
            long sumGold = 0;
            long sumCash = 0;
            long totalSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    currenceName = input[i];
                }
                else
                {
                    continue;
                }
                if (input.Length % 2 != 0)
                {
                    input[input.Length] = "";
                }
                currenceAmmount = long.Parse(input[i + 1]);
                if (totalSum + currenceAmmount > bagCapacity)
                {
                    break;
                }
                if (currenceName == "Gold")
                {
                    if (gold.ContainsKey(currenceName) == false)
                    {
                        gold.Add(currenceName, 0);
                    }
                    gold[currenceName] += currenceAmmount;
                }
                else if (currenceName.Length >= 4 && currenceName.EndsWith("gem"))
                {
                    if (gems.ContainsKey(currenceName) == false)
                    {
                        if (sumGem + currenceAmmount > sumGold)
                        {
                            continue;
                        }
                        gems.Add(currenceName, 0);
                    }
                    gems[currenceName] += currenceAmmount;
                }

                else if (currenceName.All(char.IsLetter) && currenceName.Length == 3)
                {
                    if (cashes.ContainsKey(currenceName) == false)
                    {
                        if (sumCash + currenceAmmount > sumGem)
                        {
                            continue;
                        }
                        cashes.Add(currenceName, 0);
                    }
                    cashes[currenceName] += currenceAmmount;
                }

                sumCash = cashes.Values.Sum();
                sumGem = gems.Values.Sum();
                sumGold = gold.Values.Sum();
                totalSum = sumGold + sumGem + sumCash;

            }

            if (sumGold != 0)
            {
                Console.WriteLine($"<Gold> ${sumGold}");
            }
            foreach (var item in gold.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
            {
                Console.WriteLine($"##{item.Key} - {item.Value}");
            }

            if (sumGem != 0)
            {
                Console.WriteLine($"<Gem> ${sumGem}");
            }
            foreach (var gem in gems.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
            {
                Console.WriteLine($"##{gem.Key} - {gem.Value}");
            }

            if (sumCash != 0)
            {
                Console.WriteLine($"<Cash> ${sumCash}");
            }

            foreach (var cash in cashes.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
            {
                Console.WriteLine($"##{cash.Key} - {cash.Value}");
            }


        }
    }
}
