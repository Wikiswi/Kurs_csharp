

//Console.WriteLine("Zadanie 1");


//int sumPrimNumbers = 0; // Inicjalizacja zmiennej przechowującej liczbę znalezionych liczb pierwszych


//int number = 0;  // Inicjalizacja zmiennej używanej do iteracji przez liczby od 0 do 100 // zmienna przechowuje liczbę od 0 - 100


//while (number <= 100) // Pętla while będzie działać dopóki wartość zmiennej number jest mniejsza lub równa 100
//{

//    int counter = 0;  // Inicjalizacja licznika dzielników dla aktualnej liczby

//    for (int j = 1; j <= number; j++) // Pętla for iteruje przez liczby od 1 do aktualnej liczby (number)
//    {
//        if (number % j == 0)        // Sprawdzenie, czy aktualna liczba (number) jest podzielna przez j
//        {
//            counter++;       // Jeśli podzielna, zwiększenie licznika dzielników
//        }
//    }


//    if (counter == 2)    // Jeśli licznik dzielników ma wartość 2, to liczba jest pierwsza
//    {
//        Console.WriteLine("Znalazłem liczbę pierwszą: " + number);  // wyświetli liczbę pierwszą
//        sumPrimNumbers++;   // Zwiększenie licznika znalezionych liczb pierwszych
//    }


//    number++;  // Zwiększenie wartości zmiennej number, aby przejść do następnej liczby
//}

//Console.WriteLine($"W zakresie 0-100 jest {sumPrimNumbers} liczb pierwszych");  // Wyświetlenie liczby znalezionych liczb pierwszych w zakresie 0-100





//// zad. 2 Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.

//Console.WriteLine("Zadanie 2");

//int number2 = 0;

//do
//{
//    if (number2 % 2 == 0)
//    {
//        Console.WriteLine("Liczba parzysta" + number2);
//    }
//    number2++;
//}
//while (number2 <= 1000);




//// zad 3. Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.

//Console.WriteLine("Zadanie 3");

//Console.WriteLine("Podaj liczbę F");

//string userInput = Console.ReadLine();

//int numberF;

//int.TryParse(userInput, out numberF);

//int f1 = 0;
//int f2 = 1;
//int f3;


//if (int.TryParse(userInput, out numberF))
//{
//    Console.Write($"Ciąg Fibonacciego: {f1}, {f2}, ");  // te wyświetlamy bo te znamy
//    for (int i = 0; i < numberF - 2; i++)  // -2 bo pierwsze 2 znamy, bez tego wyświetli nam o 2 więcej z f1 i f2 
//    {
//        f3 = f1 + f2;

//        Console.Write(f3 + " ");
//        f1 = f2;
//        f2 = f3;
//    }
//}
//else
//    Console.WriteLine("wstaw liczbę a nie znak");

//Console.WriteLine();




////zad 4. Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:
////1
////2 3
////4 5 6
////7 8 9 10

//Console.WriteLine("zadanie 4");


//Console.WriteLine("Podaj liczbę do wygenerowania piramidy:"); // Prośba o podanie liczby do wygenerowania piramidy

//int num = Int32.Parse(Console.ReadLine()); // Wczytanie wprowadzonej liczby jako tekst i przekształcenie go na liczbę całkowitą

//int aktualnaLiczbaRzędu = 1; // Inicjalizacja aktualnej liczby do wyświetlenia na piramidzie
//int poziom = 1;   // Inicjalizacja zmiennej poziomu piramidy

//while (poziom <= num)      // Pętla tworząca kolejne poziomy piramidy
//{

//    for (int i = 0; i < poziom; i++)   // Pętla tworząca schodki, rzędy/poziomy na danym poziomie
//    {
//        if (aktualnaLiczbaRzędu <= num) // Sprawdzenie, czy aktualna liczba schodka/rzędu nie przekroczyła wprowadzonej liczby
//        {

//            Console.Write($"{aktualnaLiczbaRzędu} "); // Wyświetlenie aktualnej liczby rzędu
//            aktualnaLiczbaRzędu++; // Zwiększenie aktualnej liczby o 1
//        }
//    }
//    Console.WriteLine(); // Przejście do nowej linii po zakończeniu poziomu

//    poziom++; // Zwiększenie numeru poziomu o 1, aby przejść na kolejny poziom
//}






//// zad. 5 Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę


//Console.WriteLine("zadanie 5");

//for (int i = 0; i <= 20; i++)
//{
//    int potęga = (int)Math.Pow(i, 3);
//    Console.WriteLine($"Liczba: {i}, Trzecia potęga to: {potęga}");
//}




//// Zad. 6 Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru: 1 + ½ +1 / 3 + ¼

//Console.WriteLine("Zadanie 6");

//double sum = 0;

//for (int i = 1; i <= 20; i++)  // iteruje od 1 by uniknąć dzielenia przez 0?
//{
//    sum = sum + 1.0 / i;

//}
//Console.WriteLine(sum);






////zad. 7  Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:     NIE WIEM
////*
////***
////*****
////*******
////*********
////*******
////*****
////***
////*



//Console.Write("Podaj przekątną diamentu: "); // Prośba o podanie długości przekątnej.
//if (int.TryParse(Console.ReadLine(), out int numberDiamond)) // Próba sparsowania podanej wartości na liczbę całkowitą.
//{
//    int firstRow = 1; // Inicjalizacja długości pierwszego wiersza.

//    if (numberDiamond % 2 == 0) // Sprawdzenie, czy przekątna jest parzysta.
//    {
//        firstRow = 2; // Jeśli parzysta, pierwszy wiersz ma długość 2.
//    }

//    // Rysowanie górnego pół diamentu (do środka).
//    for (int i = firstRow; i <= numberDiamond; i += 2) // Iteracja po wierszach diamentu.
//    {
//        // Rysowanie spacji przed gwiazdkami, aby wyśrodkować diament.
//        for (int j = (numberDiamond - i) / 2; j >= 0; j--)
//        {
//            Console.Write(" ");
//        }

//        // Rysowanie gwiazdek w wierszu diamentu.
//        for (int j = 1; j <= i; j++)
//        {
//            Console.Write("*");
//        }

//        Console.WriteLine(); // Przejście do nowej linii po narysowaniu wiersza.
//    }

//    // Rysowanie dolnego pół diamentu (po środku).
//    for (int i = numberDiamond - 2; i >= firstRow; i -= 2) // Iteracja po wierszach diamentu.
//    {
//        // Rysowanie spacji przed gwiazdkami, aby wyśrodkować diament.
//        for (int j = 0; j < (numberDiamond - i + 2) / 2; j++)
//        {
//            Console.Write(" ");
//        }

//        // Rysowanie gwiazdek w wierszu diamentu.
//        for (int j = 1; j <= i; j++)
//        {
//            Console.Write("*");
//        }

//        Console.WriteLine(); // Przejście do nowej linii po narysowaniu wiersza.
//    }
//}

////zad 8. Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
////Testowe dane:
////Abcdefg
////Rezultat
////Gfedcba


//Console.WriteLine("Podaj słowo do odwrócenia: ");
//string słowo = Console.ReadLine();


//for (int i = słowo.Length - 1; i >= 0; i--)

//{
//    Console.Write(słowo[i]);

//    Console.WriteLine("/n");

//    Console.WriteLine(słowo[i]);
//}





// zad. 9 Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.

//Console.WriteLine("podaj liczbę dziesiętną");

//string userInput9 = Console.ReadLine();
//decimal liczbaB; // przechowuje liczbę binarną
//decimal.TryParse(userInput9, out liczbaB);


Console.WriteLine("Podaj liczbę dziesiętną: ");
int liczbaDz = int.Parse(Console.ReadLine()); // Wczytanie liczby dziesiętnej od użytkownika.

string liczbaB = " "; // Zmienna przechowująca reprezentację binarną.

if (liczbaDz == 0)
{
    liczbaB = "0"; // Obsługa specjalnego przypadku: zamiana zera na liczbę binarną.
}
else
{
    while (liczbaDz > 0)
    {
        int resztaDzielenia = liczbaDz % 2; // Reszta z dzielenia przez 2.
        liczbaB = resztaDzielenia + liczbaB; // Dodanie reszty do początku liczby binarnej.
        liczbaDz /= 2; // Dzielenie liczby dziesiętnej przez 2.
    }
}
Console.WriteLine("Liczba binarna: " + liczbaB); // Wyświetlenie wyniku.



// zad. 10 Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb NIE zrobione





string tes = "tes";