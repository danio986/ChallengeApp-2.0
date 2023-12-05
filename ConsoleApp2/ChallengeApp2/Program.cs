string name = "Ew";
int age = 33;
bool male = false;

if (male == true)
{
    if (age >= 18)
    {
        Console.WriteLine("Pelnoletni Mezczyzna");
    }
    else
    {
        Console.WriteLine("Niepelnoletni Mezczyzna");
    }
}

if (male == false)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta ponizej 30 lat");
    }
    if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else
    {
        Console.WriteLine("Kobieta w wieku conajmniej 30 lat");
    }
}


//int myAge = 30;
//int newAge = myAge + 5;
//float myNumber = 0;
//double myNumber2 = 2;


//// zmienne tekstowe
//string name = "Daniel";
//string surname = "Jankowski";
//char myVar = 'a'; // zmienna z tylko jednym znakiem

//string result = name + surname;
//Console.WriteLine(result);


//// zmienne logiczne
//bool isActive = false;   // przyjmuje tylko dwie wartości (true/false)

//var isValid = 5 > 6;
//Console.WriteLine(isValid);

// if
// ==
// <
// >
// <=
// >=
// !=

// && - i
// || - lub
// ! - negacja


// czyszczenie kodu - ctrl + k + d