






// zad 1 Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
int x = 5;
int y = 5;

if (x == y)
{
    Console.WriteLine("Liczby są sobie równe");
}
else
    Console.WriteLine("nie są sobie równe");




// zad. 2  Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.
Console.WriteLine("podaj liczbę");

int liczba = int.Parse(Console.ReadLine());

if (liczba % 2 == 0)
{
    Console.WriteLine($"Liczba {liczba} jest parzysta");
}
else
    Console.WriteLine("liczba jest nieparzysta");



// zad. 3 Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.

Console.WriteLine("podaj liczbę to sprawdzę czy liczba jest dodatnia czy ujemna");

int liczba2 = int.Parse(Console.ReadLine());

if (liczba2 > 0)
{
    Console.WriteLine($"Liczba {liczba2} jest dodatnia");
}
else
    Console.WriteLine($"liczba {liczba2} jest ujemna");


// zad. 4 Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.



Console.WriteLine("Podaj rok");

string userInput4 = Console.ReadLine();

int rok;

int.TryParse(userInput4, out rok);

if (rok % 4 == 0)
{
    Console.WriteLine($" rok {rok} jest przestępnym");
}
else
{
    Console.WriteLine($"rok {rok} jest rokiem zwykłym");
}




// zad. 5 Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,prezydenta.

// zle zrobione 


Console.WriteLine("podaj wiek");

int wiek = int.Parse(Console.ReadLine());

if (wiek >= 21)
{
    Console.WriteLine("Możesz zostać posłem, premierem");
}
else if (wiek >= 30)
{
    Console.WriteLine("Możesz zostać posłem, premierem, senatorem");
}
else if (wiek >= 35)
{
    Console.WriteLine("Możesz zostać posłem, premierem, senatorem, prezydnetem");
}
else
{
    Console.WriteLine("Jesteś niepełnoletni");
}




// zad. 6 Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.

Console.WriteLine("podaj wzrost");

float wzrost = float.Parse(Console.ReadLine());

//if (wzrost <= 100)
//{
//    Console.WriteLine("jestes bardzo mały");
//}
//else if (wzrost > 100 && wzrost <= 150)
//    Console.WriteLine("Jesteś nieco większy");
//else if (wzrost > 150 && wzrost <= 200)
//    Console.WriteLine("Jesteś normalny");
//else
//{
//    Console.WriteLine("jesteś wielkoludem");
//}

switch (wzrost)
{
    case >= 200:
        Console.WriteLine("Jesteś wielkoludem");
        break;

    case >= 150:

        Console.WriteLine("jesteś normalny");
        break;


    case >= 100:
        Console.WriteLine("jesteś nieco większy");
        break;
    default:
        Console.WriteLine("Jesteś mały");
        break;
}


//switch (wzrost)
//{
//    case >= 200:
//        Console.WriteLine("Jesteś wielkoludem");
//        break;
//    case (wzrost>= 150 && wzrost<200):
//        Console.WriteLine("jesteś normalny");
//        break;
//    case >= 100:
//        Console.WriteLine("jesteś nieco większy");
//        break;
//    default:
//        Console.WriteLine("Jesteś mały");
//        break;
//}




//zad. 7  Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi,która jest największa


Console.WriteLine("podaj 1 liczbę");
int liczbaFirst = int.Parse(Console.ReadLine());

Console.WriteLine("podaj 2 liczbę");
int liczbaSecond = int.Parse(Console.ReadLine());

Console.WriteLine("podaj 3 liczbę");
int liczbaThird = int.Parse(Console.ReadLine());

int MaxValue = liczbaFirst;


if (liczbaSecond > MaxValue)
{
    MaxValue = liczbaSecond;
}

if (liczbaThird > MaxValue)
{
    MaxValue = liczbaThird;
}

Console.WriteLine($"Największa liczba to: {MaxValue}");


// zad. 8 . Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. kryteriów  

int mat = 80;
int fiz = 71;
int chem = 0;

int sum = mat + fiz + chem;

if (sum >= 180 || mat + fiz > 150 || mat + chem > 150)
{
    Console.WriteLine("Kandydat dopuszczony do rekrutacji ");

}
else
{
    Console.WriteLine("Nie dopuszczony");
}

// zad. 9. Napisz program, który odczyta temperaturę I zwróci nazwę jak w
//poniższych kryteriach
//Temp < 0 – cholernie piździ
//Temp 0 – 10 – zimno
//Temp 10 – 20 – chłodno
//Temp 20 – 30 – w sam raz
//Temp 30 – 40 – zaczyna być słabo, bo gorącoTemp >= 40 – a weź wyprowadzam się na Alaskę

Console.WriteLine("Podaj temperaturę");
string inputUser = Console.ReadLine();
int temp;

bool success = int.TryParse(inputUser, out temp);

if (temp < 0)
{
    Console.WriteLine("Cholernie piździ");
}
if (temp > 0 && temp < 10)
{
    Console.WriteLine("zimno");
}
else if (temp > 10 && temp < 20)
{ Console.WriteLine("chłodno"); }

else if (temp > 20 && temp < 30)
{
    Console.WriteLine("w sam raz");
}
else if (temp > 30 && temp < 40)
{
    Console.WriteLine("zaczyna być słabo bo gorąco");
}
else if (temp > 40)
{
    Console.WriteLine("a weź wyprowadzam sie na Alaskę");
}
else if (success == false)
{
    Console.WriteLine(" to nie jest temperatura");
}

// zad. 10 Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt
// Dane testowe : 40 55 65

int a = 40;
int b = 55;
int c = 65;

if (a + b > c || a + c > b || b + c > a)
{
    Console.WriteLine(" udało się stworzyć trójkąt ");
}
else
{
    Console.WriteLine(" najdłuższy bok jest większy niż suma krótszych, stąd się nie uda");
}

// zad. 11 Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
//6 Celujący
//5 Bardzo dobry
//4 Dobry
//3 Dostateczny
//2 Dopuszczający
//1 Niedostateczny

Console.WriteLine("podaj ocenę w postaci cyfry");

string inputUser2 = Console.ReadLine();

int ocena;
int.TryParse(inputUser2, out ocena);




switch (ocena)
{
    case 1:
        Console.WriteLine("niedostateczny");
        break;
    case 2:
        Console.WriteLine("dopuszczający");
        break;
    case 3:
        Console.WriteLine("dostateczny");
        break;
    case 4:
        Console.WriteLine("dobry");
        break;
    case 5:
        Console.WriteLine("bardzo dobry");
        break;
    case 6:
        Console.WriteLine("celujący");
        break;
    default:
        Console.WriteLine(" to nie jest ocena");
        break;
}

// zad 12  Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę Dane testowe : 4 Rezultat w terminalu :Czwartek

Console.WriteLine("Podaj nr dnia tygodnia");

string userInput12 = Console.ReadLine();

int nrDnia;
int.TryParse(userInput12, out nrDnia);

switch (nrDnia)
{
    case 1:
        Console.WriteLine(" Poniedziałek");
        break;
    case 2:
        Console.WriteLine(" wtorek");
        break;
    case 3:
        Console.WriteLine(" środa");
        break;
    case 4:
        Console.WriteLine(" czwartek");
        break;
    case 5:
        Console.WriteLine(" piątek");
        break;
    case 6:
        Console.WriteLine(" sobota");
        break;
    case 7:
        Console.WriteLine(" Niedziela");
        break;
}

// zad. 13 Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem
//Podaj pierwszą liczbę:
//…
//Podaj drugą liczbę:
//…
//Podaj numer operacji do wykonania:
//1.Dodawanie
//2.Odejmowanie
//3.Mnożenie
//4.Dzielenie
//…
//Twój wynik to:




Console.WriteLine("Podaj pierwszą liczbę");
string userInput1 = Console.ReadLine();
decimal pierwszaLiczba;
decimal.TryParse(userInput1, out pierwszaLiczba);

Console.WriteLine("Podaj drugą liczbę");
string userInput2 = Console.ReadLine();
decimal drugaLiczba;

decimal.TryParse(userInput2, out drugaLiczba);

Console.WriteLine("Podaj nr operacji do wykonania. 1. Dodawanie\r\n 2. Odejmowanie\r\n 3. Mnożenie\r\n 4. Dzielenie");

string userWybór = Console.ReadLine();
int wynik;

int.TryParse(userWybór, out wynik);

decimal suma = pierwszaLiczba + drugaLiczba;
decimal odejmowanie = pierwszaLiczba - drugaLiczba;
decimal mnożenie = pierwszaLiczba * drugaLiczba;

switch (wynik)
{
    case 1:
        Console.WriteLine($"Twój wynik to {suma}");
        break;
    case 2:
        Console.WriteLine($"Twój wynik to  {odejmowanie}");
        break;
    case 3:
        Console.WriteLine($"Twój wynik to  {mnożenie}");
        break;
    case 4:
        if (drugaLiczba == 0)
        {
            Console.WriteLine("Nie można dzielić przez zero");
        }
        //else if (drugaLiczba != 0)    // inny sposób 
        //{
        //    Console.WriteLine($"Twój wynik to {pierwszaLiczba/drugaLiczba}");
        //}
        else
        {
            Console.WriteLine($"Twój wynik to {pierwszaLiczba / drugaLiczba}");
        }
        break;
    default:
        Console.WriteLine("Wybierz właściwe działanie");
        break;
}







