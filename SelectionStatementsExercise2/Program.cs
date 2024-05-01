namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ramsay High School! What is your favorite subject?");
            string favSubject = Console.ReadLine();

            switch (favSubject)

            {
                case "Math":
                    Console.WriteLine("We will add Math to your schedule!");
                    break;
                case "English":
                    Console.WriteLine("We will add English to your schedule!");
                    break;
                case "Spanish":
                    Console.WriteLine("We will add Spanish to your schedule!");
                    break;
                case "Science":
                    Console.WriteLine("We will add Science to your schedule!");
                    break;
                case "History":
                    Console.WriteLine("We will add History to your schedule!");
                    break;
                default:
                    Console.WriteLine($"We do not have {favSubject} here at Ramsay, we will add it next semester!");
                    break;

            }
        }
    }
}