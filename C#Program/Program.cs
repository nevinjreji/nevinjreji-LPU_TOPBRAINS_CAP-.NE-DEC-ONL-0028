using System;

class Program
{
    static bool IsVowel(char ch)
    {
        ch = char.ToLower(ch);
        return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
    }

    static void Main()
    {
        string first = Console.ReadLine()!;
        string second = Console.ReadLine()!;

        string temp = "";

        // remove common consonants
        foreach (char ch in first)
        {
            char c = char.ToLower(ch);

            if (!IsVowel(c) && second.ToLower().Contains(c))
                continue;

            temp += ch;
        }

        string result = "";

        // remove consecutive duplicates
        for (int i = 0; i < temp.Length; i++)
        {
            if (i == 0 || temp[i] != temp[i - 1])
                result += temp[i];
        }

        Console.WriteLine(result);
    }
}
