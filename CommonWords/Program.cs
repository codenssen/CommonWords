using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{
    public static void Main(string[] args)
    {
        string paragraph = "Bob hit a ball, the hit BALL ball flew far after it was hit.";
        string[] banned = ["hit"];
        string[] words = StringToArray(paragraph);
        Console.WriteLine(CommonWord(words, banned));
    }

    public static string[] StringToArray(string paragraph)
    {
        string[] returnedString = paragraph.Split(' ');
        char[] charsToTrim = { '*', ',', '.', '?', '!', ';' };
        int index = 0;
        foreach (string word in returnedString)
        {
            returnedString[index] = word.Trim(charsToTrim).ToLower();
            index++;
        }

        return returnedString;

    }

    public static string CommonWord(string[] words, string[] banned)
    {
        List<string> wordList = new List<string>();
        List<int> wordCount = new List<int>();
        int index = 0;
        string returnString = "";
        Console.WriteLine(banned.Contains("hit"));

        foreach (string word in words)
        {
            if (!banned.Contains(word))
            {
                if (wordList.Contains(word))
                {
                    int wordIndex = wordList.IndexOf(word);
                    wordCount[wordIndex] += 1;
                }
                else
                {
                    wordList.Add(word);
                    wordCount.Add(1);
                }
            }

            index++;
        }

        for (int i = 0; i < wordList.Count; i++)
        {
            Console.WriteLine($"{wordList[i]} - {wordCount[i]}");
        }

        index = 0;
        foreach (int count in wordCount)
        {
            if (count == wordCount.Max())
            {
                returnString = returnString + " " + wordList[index];
            }
            index++;
        }
        return returnString;

    }

    public static void PrintStringArray(string[] array)
    {

        foreach (string word in array)
        {
            Console.WriteLine($"{word} ");
        }

    }




}