

    
        Console.WriteLine("Hello: " + "Elias");

        Random ranGen = new Random();

        int x = 4;
        int y = 2;

        float gange = x * y;
        float divider = x / y;

        Console.WriteLine(gange);
        Console.WriteLine(divider);

        float z = -1 + 4 * 6;
        float a = (35 + 5) % 7;
        float b = 14 + -4 * 6 / 11;
        float c = 2 + 15 / 6 * 1 - 7 % 2;

        Console.WriteLine(z);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

        float a1 = 4;
        float b1 = 6;


            Console.WriteLine(a1);
            Console.WriteLine(b1);
        
        float temp = a1;
        a1 = b1;
        b1 = temp;

            Console.WriteLine(a1);
            Console.WriteLine(b1);
        
int a2 = 5;
int b2 = 6;
int c2 = 7;

int sum = a2 * b2 * c2;

Console.WriteLine("5*6*7 = "+ sum);



int x1; // Variable to store the user input number
int result; // Variable to store the result of multiplication

 Console.WriteLine("Enter a number:"); // Prompting the user to enter a number
 Console.WriteLine("I will present to you the table for that number");
 x1 = Convert.ToInt32(Console.ReadLine()); // Reading the number entered by the user and converting it to an integer

     // Loop through numbers from 1 to 10 to generate multiplication table for the entered number
     result = x1 * 1;
     Console.WriteLine("The table is : {0} x {1} = {2}", x1, 1, result);
    result = x1 * 2;
    Console.WriteLine("             : {0} x {1} = {2}", x1, 2, result);
    result = x1 * 3;
    Console.WriteLine("             : {0} x {1} = {2}", x1, 3, result);
    result = x1 * 4;
    Console.WriteLine("             : {0} x {1} = {2}", x1, 4, result);
    result = x1 * 5;
    Console.WriteLine("             : {0} x {1} = {2}", x1, 5, result);
    result = x1 * 6;
    Console.WriteLine("             : {0} x {1} = {2}", x1, 6, result);
    result = x1 * 7;
    Console.WriteLine("             : {0} x {1} = {2}", x1, 7, result);
    result = x1 * 8;
    Console.WriteLine("             : {0} x {1} = {2}", x1, 8, result);
    result = x1 * 9;
    Console.WriteLine("             : {0} x {1} = {2}", x1, 9, result);
    result = x1 * 10;
    Console.WriteLine("             : {0} x {1} = {2}", x1, 10, result);

   Console.WriteLine("nu skal vi multiplere 2 tal, de tal skal du vælge");

   int x2; // Variable to store the user input number
   int x3;
   int result1 ;

    Console.WriteLine("Enter a number:"); // Prompting the user to enter a number
    x2 = Convert.ToInt32(Console.ReadLine()); // Reading the number entered by the user and converting it to an integer

     Console.WriteLine("Enter a number:"); // Prompting the user to enter a number
    x3 = Convert.ToInt32(Console.ReadLine()); // Reading the number entered by the user and converting it to an integer

result1 = x2 * x3;
Console.WriteLine("{0} * {1} = {2}", x2, x3, result1);

float resultat2;

int Anthon = 10;
int Elias = 5;
int Marcelly = 7;
int Mads = 8;

resultat2 = (Anthon + Elias + Marcelly + Mads) / 4;

Console.WriteLine("gennemsnittet er: {0}", resultat2);

int x4;
int resultat4;
int benjo = ranGen .Next(15, 69);

Console.WriteLine("skriv din alder");
x4 = Convert.ToInt32(Console.ReadLine());

resultat4 = x4 + benjo;

Console.WriteLine("Du ligner en på {0}", resultat4);

int x5;


Console.WriteLine("skriv et tal");
x5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("{0} {0} {0} {0} {0}", x5);
Console.WriteLine("{0}{0}{0}{0}{0}", x5);
Console.WriteLine("{0} {0} {0} {0} {0}", x5);
Console.WriteLine("{0}{0}{0}{0}{0}", x5);



int x6;

Console.WriteLine("skriv et tal");
x6 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("{0} {0} {0}",  x6);
Console.WriteLine("{0}   {0} ", x6);
Console.WriteLine("{0}   {0} ", x6);
Console.WriteLine("{0}   {0} ", x6);
Console.WriteLine("{0} {0} {0} ", x6);



int x7;

Console.WriteLine("skriv et tal");
x7 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("     {0}",  x7);
Console.WriteLine("     {0} ", x7);
Console.WriteLine("     {0} ", x7);
Console.WriteLine("     {0} ", x7);
Console.WriteLine("  {0}  {0}  {0}", x7);


float x8;

Console.WriteLine("skriv noget i celsius og jeg laver det til fahrenheit og kelvin");
x8 = Convert.ToInt32(Console.ReadLine());

float resultatJ = x8 * 1.8f + 32;
float resultatE = x8 + 273;

Console.WriteLine("fahrenheit: {0}" + " Kelvin {1}", resultatJ, resultatE);