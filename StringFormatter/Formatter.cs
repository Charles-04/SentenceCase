using System;
using System.Linq;

namespace StringFormatter
{
    public static class Formatter
    {
        public static string ToSentenceCase(string Word)
        {
            try
            {

                var WordLength = Word.Trim().ToList().Count;
                string NewWord = null;
                if (WordLength > 1)
                {
                    var FirstCharacter = Word.Trim().Substring(0, 1).ToUpper(); 
                    NewWord = FirstCharacter + Word.Substring(1, WordLength - 1).ToLower();

                }
                else
                {
                    Console.WriteLine("String length too short");
                }
                return NewWord;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
