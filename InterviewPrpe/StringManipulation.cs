using System.Text;

namespace InterviewPrpe
{
    internal class StringManipulation
    {
        public static string ReverseString(string input)
        {
            string result = string.Empty;
            //patrick
            for(int i = input.Length-1; i >= 0; i--)
            {
                result+= input[i];
            }
            return result;
        }
        public static string Palindrome(string input)
        {
            string result = string.Empty;
            //patrick
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }
            return result==input ? "Palindrome" : "Not a Palindrome";
        }

        public static string PalindromeNumber(int number)
        {
            int originalNumber = number;
            int sum = 0;
            while(number > 0)
            {
                int remainder = number % 10;
                sum = (sum * 10) + remainder;
                number = number/10;
            }

            return originalNumber == sum ? "Palindrome" : "Not a Palindrome";
        }

        public static StringBuilder ReverseOrderOfWords(string input)
        {
            StringBuilder result = new StringBuilder();
            int end = input.Length - 1;
            //Welcome to Sweden
            for(int i= input.Length-1; i>=0; i--)
            {
                if (input[i] == ' ' || i < 0)
                {
                    int j = i+1;
                    while (j <= end)
                    {
                        result.Append(input[j]);
                        j++;
                    }
                    end = i - 1;
                    result.Append(' ');
                }
            }
            //one more loop to print the first word
            return result;
        }

        public static StringBuilder ReverseWords(string input)
        {
            StringBuilder result = new StringBuilder();
            int end = 0;
            for(int i=0;i< input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    for(int j = i-1; j >= end; j--)
                    {
                        result.Append(input[j]);
                    }
                    result.Append(' ');
                    end = i + 1;
                }
            }
            for(int i = input.Length-1; i>= end; i--)
            {
                result.Append(input[i]);
            }
            return result;
        }

        public static string RemoveDuplicateCharactrers(string input)
        {
            string result = string.Empty;
            //Ikigai
            foreach (char character in input.ToLower())
            {
                if(!result.Contains(character))
                {
                    result += character;
                }
            }
            return result;
        }

        public static void FindAllSubstrings(string input)
        {
            // abcd : a ab abc abcd b bc bcd c cd d
            for(int i=0; i<input.Length;i++)
            {
                StringBuilder builder = new StringBuilder(input.Length - i);
                for(int j = i; j< input.Length; j++)
                {
                    builder.Append(input[j]);
                    Console.WriteLine(builder + " ");
                }
                
            }
        }

        public static void LeftCircularRotation(int[] numbers)
        {
            //shift each character to left by one position
            //12345 : 23451

            for(int i = 0; i < numbers.Length-1; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[i+1];
                numbers[i+1] = temp;
            }
            foreach(int number in numbers)
            {
                Console.Write(number);
            }
        }
        internal static void RotateLeft(int[] array)
        {
            int size = array.Length;
            int temp;
            for (int j = size - 1; j > 0; j--)
            {
                temp = array[size - 1];
                array[array.Length - 1] = array[j - 1];
                array[j - 1] = temp;
            }

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
    }
}
