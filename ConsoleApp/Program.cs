
//deklaracja zmiennej lokalnej o typie string i nazwie helloVariable
using System.Globalization;

string helloVariable;
//inicjalizacja zmiennej - pierwsze przypisanie wartości
helloVariable = "Hello";

//deklaracja z inicjalizacją
string worldVariable = "World";

//średnik oznacza koniec pojedynczej instrukcji

//C# wspiera przeciążanie metod,
//czyli jedna nazwa metody może byc przypisana do wielu metod jeżli różnią się ilością i typem parametrów
Console.WriteLine(helloVariable);
Console.WriteLine();
Console.WriteLine(worldVariable);

Console.Write(helloVariable);
Console.Write(" ");
Console.Write(worldVariable);

//przypisanie wartości
worldVariable = " Students!";
Console.WriteLine(worldVariable);


string input = Console.ReadLine();
input = input.ToUpper();
Console.WriteLine(input);


//łączenie stringów za pomocą +
string output = "*-*" + helloVariable + " " + input + "*-*";
Console.WriteLine(output);

//łączenie stringów za pomocą string.Format
output = string.Format("*-*{0} {1}*-*", helloVariable, input);
Console.WriteLine(output);

output = string.Format("*-*{1} {0}*-*", helloVariable, input);
Console.WriteLine(output);

//string interpolowany
output = $"*-*{helloVariable} {input}*-*";
Console.WriteLine(output);

output = "*-*{helloVariable} {input}*-*";
Console.WriteLine(output);

output = $"Your input string ({input}) has {input.Length} letters";
Console.WriteLine(output);

//zastąpienie części ciągu znaków - czułe na wielkość liter
output = output.Replace("Your", "My");
Console.WriteLine(output);

//zastąpienie części ciągu znaków - niezależnie od wielkości liter
output = output.Replace("your", "My", true, CultureInfo.CurrentCulture);
Console.WriteLine(output);