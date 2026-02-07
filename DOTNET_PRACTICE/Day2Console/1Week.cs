using System;
namespace Day2Console;
    public class BubbleSortArray
    {
        // Function to take array input from user
        public int[] ReadArray()
        {
            Console.Write("Enter number of elements: ");
            int size = int.Parse(Console.ReadLine()!);

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine()!);
            }

            return numbers;
        }

        // Bubble Sort function
        public int[] Sort(int[] numbers)
        {
            int n = numbers.Length;
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < n - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);

            return numbers;
        }

        public string GetFormattedOutput(int[] numbers)
        {
            string result = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                result = result + numbers[i] + " ";
            }

            return result;
        }
    }