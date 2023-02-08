using System.Globalization;


int a = 11;
int b = 4;

int c = a + b;
Console.WriteLine($"{a} + {b} = {c}");
c = a - b;
Console.WriteLine($"{a} - {b} = {c}");
c = a * b;
Console.WriteLine($"{a} * {b} = {c}");
c = a / b;
Console.WriteLine($"{a} / {b} = {c}");
c = a % b;
Console.WriteLine($"{a} % {b} = {c}");


c = a + a * a;
Console.WriteLine($"{a} + {a} * {a} = {c}");
c = (a + a) * a;
Console.WriteLine($"({a} + {a}) * {a} = {c}");



float aa = 11.0f;
float bb = 4f;
float cc = aa + bb;
Console.WriteLine($"{aa} + {bb} = {cc}");
cc = aa - bb;
Console.WriteLine($"{aa} - {bb} = {cc}");
cc = aa * bb;
Console.WriteLine($"{aa} * {bb} = {cc}");
cc = aa / bb;
Console.WriteLine($"{aa} / {bb} = {cc}");



Console.WriteLine($"short min:{short.MinValue} max:{short.MaxValue}");
Console.WriteLine($"int min:{int.MinValue} max:{int.MaxValue}");
Console.WriteLine($"long min:{long.MinValue} max:{long.MaxValue}");

Console.WriteLine($"float min:{float.MinValue} max:{float.MaxValue}");
Console.WriteLine($"double min:{double.MinValue} max:{double.MaxValue}");
Console.WriteLine($"decimal min:{decimal.MinValue} max:{decimal.MaxValue}");

//dzielenie int przez float/double/decimal (albo odrwotnie) daje wynik w typie o wyższej precyzji
Console.WriteLine(5 / 3.3f);
Console.WriteLine(5 / 3.3d);
Console.WriteLine(5 / 3.3m);

//przepełnienie int
a = int.MaxValue;
Console.WriteLine($"a = {a}");
Console.WriteLine($"a + 1 = {a + 1}");


int intMaxVal = int.MaxValue;
long longMaxVal = long.MaxValue;


long longVal = intMaxVal;
Console.WriteLine(longVal);

//rzutowanie
int intVal = (int)1L;
Console.WriteLine(intVal);
//rzutowanie może przekłamać wynik jeśli jest spoza zakresu typu na który rzutujemy
intVal = (int)longMaxVal;
Console.WriteLine(intVal);

float floatVal = int.MaxValue;
Console.WriteLine(floatVal);

floatVal = (float)double.MaxValue;
Console.WriteLine(floatVal);


//parsowanie/konwertowanie string na int
string value = Console.ReadLine();
intVal = int.Parse(value);
int result = intVal * 2;
Console.WriteLine($"{intVal} * 2 = {result}");


//parsowanie/konwertowanie string na float
value = Console.ReadLine();
floatVal = float.Parse(value);
float floatResult = floatVal * 2;
Console.WriteLine($"{floatVal} * 2 = {floatResult}");


//Funckja o nazwie StringDemo, nie przyjmująca parametrów i nic nie zwracająca (void)
void StringDemo()
{
    //deklaracja zmiennej lokalnej o typie string i nazwie helloVariable
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
}