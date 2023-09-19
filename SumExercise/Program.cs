using Spectre.Console;

namespace SumExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumCalc calc = new SumCalc();
            
            Console.WriteLine(new string('_', 20));

            var result = calc.Sum(10,108);

          

            calc.IsEvenOrOdd(result, out string evenOrOdd);
            calc.SumColor(result, out string sumColor);
            calc.EvenOrOddColor(evenOrOdd, out string evenOrOddColor);

            AnsiConsole.MarkupLine($"Sum is [{sumColor}]{result}[/] and it´s [{evenOrOddColor}]{evenOrOdd}[/]");
        }
       
    }
}
