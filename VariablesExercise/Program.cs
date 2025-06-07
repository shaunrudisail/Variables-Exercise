using System.Reflection.Metadata.Ecma335;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Shaun";
            int myAge = 35;
            char myMiddleInitial = 'P';
            bool iPlayGuitar = true;
            bool iHaveToured = false;
            double myHeight = 71;
            double myWeight = 160;
            decimal myNetIncome = 41600;

            Console.WriteLine($"Hello there! My name is {myName} and I'm {myAge} years old. My middle initial is {myMiddleInitial}.");
            Console.WriteLine($"I'm {myHeight} inches tall and I weigh {myWeight} pounds.");
            Console.WriteLine($"It's {iPlayGuitar} that I am an avid guitar player. However, it's {iHaveToured} that I have ever toured playing music.");
            Console.WriteLine($"A rough estimation of my net income is ${myNetIncome}. Taxes are a killer. I wish that I could make ${myNetIncome} from touring around the country playing music!");
        }
    }
}
