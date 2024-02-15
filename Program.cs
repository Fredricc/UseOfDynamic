namespace UseOfDynamic
{
    public class SomeClass
    {
        public string Text { get; }

        public SomeClass(dynamic hopefulyText)
        {
            Text = hopefulyText;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            dynamic text = "some dynamic text";

            var toUpper = text.ToUpper();

            Console.WriteLine(toUpper);
        }
    }
}