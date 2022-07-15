using System;
public class Kata
{
    public static string DoubleChar(string s)
    {
        {

            char[] destChar = new char[s.Length * 2];

            int destIndex = 0;
            foreach (char c in s)
            {
                destChar[destIndex++] = c;
                destChar[destIndex++] = c;
            }

            string destString = new string(destChar);

            return (destString);
        }
    }
}