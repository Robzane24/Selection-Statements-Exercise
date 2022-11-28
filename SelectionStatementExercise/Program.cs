namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise One

            var favNumber = 12;

            Console.WriteLine("Please guess the number:");
            var userInput = int.Parse(Console.ReadLine());

            if(userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is too high");
            }
            else
            {
                Console.WriteLine("Congratulations, you have guessed the correct number!");
            }

            //Exercise Two

            Console.WriteLine("What is your favorite subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is my least favorite subject");
                    break;
                case "science:":
                    Console.WriteLine("I enjoy Science, but it is not my favorite");
                    break;
                case "history":
                    Console.WriteLine("I love learning about History, but it is not my favorite");
                    break;
                case "english":
                    Console.WriteLine("I am good at English, but it is not my favorite subject");
                    break;
                case "pe":
                    Console.WriteLine("PE is my favorite subject!");
                    break;
                default:
                    Console.WriteLine("I dont know that subject");
                    break;
            }
        }
    }
}
