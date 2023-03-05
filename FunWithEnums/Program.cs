//utwórz typ
using FunWithEnums;

var emp = EmpType.Contractor;
//var emp = EmpType.SalesManager  - błąd - nie ma takiej wartości w EmpType
//var emp = Contractor - błąd - Wartości Contractor nie została przypisana do wylicznia EmpType

var bonus = AskForBonus(emp);
Console.WriteLine(bonus);

//Klasa System.Enum
//Wyświtl bazowy typ wyliczenia
Console.WriteLine("EmpType uses a {0} for storage", Enum.GetUnderlyingType(emp.GetType())); //Można tak - używamy metody GetType gdy mamy zmienna naszego typu
Console.WriteLine("Shape uses a {0} for storage", Enum.GetUnderlyingType(typeof(Shape))); //albo typeof(NaszTyp) gdy znamy typ ale nie mamy zmiennej

//Wykrywanie Nazwa / wartość -> Contractor - 2
Console.WriteLine("emp is a {0} - {1}", emp.ToString(), (int)emp);

//Wbudowane enumy np. DayOfWeek
Console.WriteLine("\n\t\tWpisz jaki dziś dzień\n");
PrintDetails();
var dayOfWeek = TryGetDayOfWeek();
Console.WriteLine($"Today is: {dayOfWeek}");

//Enum jako typ zwracany
DayOfWeek TryGetDayOfWeek()
{
    while (true)
    {
        object obj;
        var str = Console.ReadLine();
        var isDayOfWeek = Enum.TryParse(typeof(DayOfWeek), str, out obj);
        if (isDayOfWeek)
        {
            return (DayOfWeek)obj;
        }
        else //else jest tu z logicznego punktu nie potrzebne
             //ponieważ jak isDayOfNumber jest true to wyjdziemy z funkcji w klauzuli if i tu nie dojdziemy
             //a jak jest false to i tak byśmy pomineli returna i przesli do tej lini kodu
             //ale wstawiłęm żeby było bardziej czytelnie (chociasz w przyszłości nie będę bo mniej kodu znaczy lepeij)
             //“Make everything as simple as possible, but not simpler.” - Albert Einstein.
        {
            Console.WriteLine("Nie ma takiej opcji, Wpisz jeszcze raz");
        }
    }
}

void PrintDetails()
{
    //array - to tablica enumów DayOfWeek[6]
    var array = Enum.GetValues(typeof(DayOfWeek));
    foreach (var item in array)
    {
        Console.WriteLine($"{(int)item} - {item}");
    }
}

// Enum jako parametr
byte AskForBonus(EmpType emp)
{
    switch (emp)
    {
        case EmpType.Manager:
            return 70;

        case EmpType.Grunt:
            return 15;

        case EmpType.Contractor:
            return 50;

        case EmpType.VicePresident:
            return 80;

        case EmpType.Worker:
            return 5;

        case EmpType.Boss:
            return 100;

        default:
            return 3;
    }
}