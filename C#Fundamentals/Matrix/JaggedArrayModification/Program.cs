using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            int[][] array = new int[lenght][];
         

            for (int row = 0; row < array.Length; row++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                array[row] = new int[input.Length];
                for (int col = 0; col < array[row].Length; col++)
                {
                    array[row][col] = input[col];
                }
            }
            var text = Console.ReadLine();

            while (text!="END")
            {
                var token = text.Split().ToArray();

                var command = token[0];
                var row = int.Parse(token[1]);
                var col = int.Parse(token [2]);
                var number = int.Parse(token[3]);

                if (command=="Add")
                {
                    if (row>=array[row].Length || row<0|| col >= array[col].Length || col < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        array[row][col] += number;
                    }
                    
                }
                else if (command=="Subtract")
                {
                    if (row >= array[row].Length || row < 0 || col >= array[col].Length || col < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        array[row][col] -= number;
                    }
                }
                text = Console.ReadLine();
            }
            foreach (var element in array)
            {
                Console.WriteLine(string.Join(" ",element));
            }
        }
    }
}
