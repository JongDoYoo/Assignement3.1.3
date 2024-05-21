namespace Assignement3._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence"); //Hi my name is Yoo
            string input = Console.ReadLine();
            Console.WriteLine("This sentence has " + NumOfSpaces(input) + (" spaces"));

        }
        static int NumOfSpaces(string input)
        {
            int space = 0;
            foreach (char letter in input)
            {
                if (letter == ' ')
                {
                    space++;
                }                             
            }
            return space;


        }
}

    }