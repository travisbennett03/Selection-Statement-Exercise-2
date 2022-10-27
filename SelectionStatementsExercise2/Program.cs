namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is a hard subject!");
                    break;
                case "Science":
                    Console.WriteLine("Science is a tough subject!");
                    break;
                case "English":
                    Console.WriteLine("English is a fun subject!");
                    break;
                case "German":
                    Console.WriteLine("German is a great subject");
                    break;
                case "Gym":
                    Console.WriteLine("Gym is a fun subject");
                    break;
                default:
                    Console.WriteLine($"Oh wow! I havent taken that subject before. {subject} sounds fun!");
                    break; 
            }
        }
    }
}