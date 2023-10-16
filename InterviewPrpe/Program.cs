// See https://aka.ms/new-console-template for more information
using InterviewPrpe;
using System.Text;

#region Reverse a string 
//string input = Console.ReadLine();
//string result = StringManipulation.ReverseString(input);
//Console.WriteLine("Reversed String {0}", result);
#endregion

#region Palindrome
//Console.WriteLine("Please enter the input value :");
//string input = Console.ReadLine();
//string result = StringManipulation.Palindrome(input);
//Console.WriteLine(result);
#endregion

#region Reverse order of words
//Console.WriteLine("Please enter the input value :");
//string input = Console.ReadLine();
//StringBuilder result = StringManipulation.ReverseOrderOfWords(input);
//Console.WriteLine(result);
#endregion

#region Reverse words
//Console.WriteLine("Please enter the input value :");
//string input = Console.ReadLine();
//StringBuilder result = StringManipulation.ReverseWords(input);
//Console.WriteLine(result);
#endregion

#region Remove duplicate characters
//Console.WriteLine("Please enter the input value :");
//string input = Console.ReadLine();
//string result = StringManipulation.RemoveDuplicateCharactrers(input);
//Console.WriteLine(result);
//Console.ReadLine();
#endregion

#region Find All substrings
//Console.WriteLine("Please enter the input value :");
//string input = Console.ReadLine();
//StringManipulation.FindAllSubstrings(input);

//Console.ReadLine();
#endregion

#region Left rotation of array

Console.WriteLine("Please the length of array :");
int length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[length];
for (int i = 0; i < length; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
StringManipulation.RotateLeft(numbers);

Console.ReadLine();
#endregion