using System;

namespace RepeatedWord
{
    public class Program
    {
        public static string repeated(string word)
        {
            word = word.ToLower();
            string[] arrWords = word.Split(' ');
            int count = 0;

            for (int i = 0; i < arrWords.Length; i++)
            {
                for (int j = 0; j < arrWords.Length; j++)
                {
                    if (arrWords[i] == arrWords[j])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    return arrWords[i];
                }
                count = 0;
            }

            return "No repetition";
        }
        static void Main(string[] args)
        {
           
        }
    }
}
