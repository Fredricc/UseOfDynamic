namespace UseOfDynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic text = "some text";

            var toUpper = text.ToUpper();

            Console.WriteLine(toUpper);
        }
    }
}