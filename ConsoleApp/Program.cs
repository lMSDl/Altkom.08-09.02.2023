using System.Globalization;


int a = 5;


a = Change(a);

Console.WriteLine(a);

int Change(int a)
{
    a = 10;
    return a;
}

Models.Item item = new Models.Item("abc");
ChangeItem(item);

void ChangeItem(Models.Item item)
{
    item.Description = "bca";
}

Models.ItemStruct itemStruct = new Models.ItemStruct("abc");
ChangeItemStruct(itemStruct);

void ChangeItemStruct(Models.ItemStruct item)
{
    item.Description = "bca";
}



//utworzenie obiektu (instancji klasy) - używany "new" oraz kontruktora
Models.Item myItem = new Models.Item();

myItem.Description = "ala ma kota";
myItem.SetValue(3);

Console.WriteLine(myItem.GetValue());
Console.WriteLine(myItem.Description);

Models.Item mySecondItem = new Models.Item("i dwa psy", 123);

Console.WriteLine(mySecondItem.GetValue());
Console.WriteLine(mySecondItem.Description);


Models.Item myThirdItem = new Models.Item("Jestem trzeci");

void ConditionsDemo()
{
    int value = int.Parse(Console.ReadLine());

    // != - różne
    if (value != 0)
    {
        Console.WriteLine($"Wartość {value} jest różne od 0");
    }


    if (value > 0)
    {
        Console.WriteLine($"Wartość {value} jest większa od 0");
    }
    else
    {
        Console.WriteLine($"Wartość {value} jest mniejsza lub równa 0");
    }



    if (value > 0)
    {
        Console.WriteLine($"Wartość {value} jest większa od 0");
    }
    else if (value < 0)
    {
        Console.WriteLine($"Wartość {value} jest mniejsza od 0");
    }
    // == - podwójny znak równości oznacza porównanie (pojedynczy przypisanie)
    else if (value == 0)
    {
        Console.WriteLine($"Wartość {value} jest równa 0");
    }

    Console.WriteLine("-----");

    if (value > 0)
    {
        Console.WriteLine($"Wartość {value} jest większa od 0");
    }

    //if (value >= 0)
    // || - lub
    if (value > 0 || value == 0)
    {
        Console.WriteLine($"Wartość {value} jest większa lub rózna 0");
    }

    //if (value == 0)
    // && - i
    // ! - negacja - wykrzyknik przed wyrażeniem
    if (!(value > 0) && !(value < 0))
    {
        Console.WriteLine($"Wartość {value} jest równa 0");
    }

    if (!(value > 0))
    {
        if (!(value < 0))
        {
            Console.WriteLine($"Wartość {value} jest równa 0");
        }
    }

    //if (value <= 0)
    if (value < 0 || value == 0)
    {
        Console.WriteLine($"Wartość {value} jest mniejsza lub równa 0");
    }

    if (value < 0)
    {
        Console.WriteLine($"Wartość {value} jest mniejsza od 0");
    }




    switch (value)
    {
        //case musi kończyć się instrukcją "break;"
        case > 0:
            Console.WriteLine($"Wartość {value} jest większa od 0");
            break;
        case < 0:
            Console.WriteLine($"Wartość {value} jest mniejsza od 0");
            break;
        case 0:
            Console.WriteLine($"Wartość {value} jest równa 0");
            break;
    }

    Console.WriteLine("Jak masz na imię?");
    string name = Console.ReadLine();

    switch (name)
    {
        case "":
            Console.WriteLine("Szkoda, że nie chcesz podać swojego imienia...");
            break;
        case "Siri":
            Console.WriteLine("Hej! masz na imię tak jak asystent Apple?");
            break;
        //default - odpowiednik "else", obsługuje każdy inny przypadek nie pasujący do żadnego case
        default:
            Console.WriteLine($"Jak się masz {name}?");
            break;
    }

}

void NumbersDemo()
{
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
}

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

void Loops()
{
    // I - inicjalizacja pętli - wykonuje się tylko raz na początku
    // II - warunek kontynuacji pętli - wykonuje się przed każym wykonaniem ciała
    // III - ciało funkcji
    // IV - akcja po wykonaniu ciałą funkcji - najczęściej inkrementacja licznika
    //for(I; II; IV)
    //{
    //  III
    //}

    for (int i = 0; i < 5; i++ /* i = i + 1 */)
    {
        Console.WriteLine(i);
    }

    int value = 3;
    //pomijamy I etap
    for (; value < 5; value++)
    {
        Console.WriteLine(value);
    }

    //Pomijamy etap I i IV
    for (; value < 7;)
    {
        Console.WriteLine(value);

        value = value + 1;
    }

    //Pomijamy etap I, II i IV (pętla nieskończona)
    for (; ; )
    {
        if (value < 20)
        {

            Console.WriteLine(value);

            value = value + 1;
        }
        else
        {
            break;
        }
    }

    for (int i = 0; ; i++)
    {
        if (i < 20)
        {

            Console.WriteLine(i);
        }
        else
        {
            break;
        }
    }


    //pętla while sprawdza warunek przed wejściem do ciała (może się nigdy nie wykonać)
    bool exit = false;
    while (!exit)
    {
        string input = Console.ReadLine();

        switch (input)
        {
            case "exit":
                exit = true;
                break;
            case "continue":
                continue;

            default:
                Console.WriteLine(input);
                break;
        }
    }

    //do-while sprawdza warunek po wykonaniu ciała - zawsze wykona się przynajmniej raz
    exit = false;
    int counter = 0;
    do
    {
        string input = Console.ReadLine();

        if (input == "exit")
        {
            exit = true;
        }
        else if (input == "break")
        {
            //break służy do przerywania pętli
            break;
        }
        else if (input == "continue")
        {
            //continue przerywa wykonywanie ciałą pętli, ale przechodzi do kolejnej iteracji pętli
            continue;
        }
        else
        {
            Console.WriteLine(input);
        }

        counter = counter + 1;

    } while (!exit);


    Console.WriteLine("End");
}

void Tree()
{
    int userInput = 5;

    int limit = userInput * 2 - 1;
    for (int i = 1; i <= userInput; i++)
    {

        int stars = i * 2 - 1;
        int spaces = (limit - stars) / 2;

        for (int j = 0; j < spaces; j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < stars; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}