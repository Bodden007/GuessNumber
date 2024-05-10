using GuessNumber;
using GuessNumber.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Controller controller = new(new ValidArgs(), new RandomGen());
        controller.RunController(args);
    }
}