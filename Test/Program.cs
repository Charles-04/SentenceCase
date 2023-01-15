using StringFormatter;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var word = Formatter.ToSentenceCase("dATtrwesW");
            Console.WriteLine(word);
        }
    }
}