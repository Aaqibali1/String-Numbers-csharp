using System.ComponentModel;

/* String songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));


int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);*/

/* int a = 5;
 int b = 4;
 int c = 2;
 int d = a + b * c;
 Console.WriteLine(d);*/

/* int a = 5; int b = 4; int c = 2;
 int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
 Console.WriteLine(d);*/


/* int a = 7;
 int b = 4;
 int c = 4;
 int d = (a + b) / c;
 int e = (a + b) / c;
 Console.WriteLine($"quotient: {d}");
 Console.WriteLine($"remainder {e}");*/


/* int max = int.MaxValue;
 int min = int.MinValue;
 Console.WriteLine($"The range of integers is {min} to {max}");

 int what = max + 3;
 Console.WriteLine($"An example of overflow: {what}");*/


/*double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);

double e = 19;
double f = 23;
double g = 8;
double h = (e + f) / g;
Console.WriteLine(h);

double max = int.MaxValue;
double min = int.MinValue;
Console.WriteLine($"The range of double is {max} to {min}");


double third = 1.0 / 3.0;
Console.WriteLine(third);


decimal maxValue = decimal.MaxValue;
decimal minValue = decimal.MinValue;
Console.WriteLine($"The range of decimal type is {maxValue} to {minValue}");
*/


/* double a = 1.0;
 double b = 3.0;
 Console.WriteLine(a/b);


 decimal c = 1.0M;
 decimal d = 3.0M;
 Console.WriteLine(c/d);
*/



/*decimal max = decimal.MaxValue;
decimal min = decimal.MinValue;
int max2 = int.MaxValue;
int min2 = int.MinValue;
long max3 = long.MaxValue;
long min3 = long.MinValue;
short min4 = short.MinValue;
short max4 = short.MaxValue;


Console.WriteLine($"The range of decimal type is {max} to {min}");
Console.WriteLine($"The range of int type is {max2} to {min2}");
Console.WriteLine($"The range of long type is {max3} to {min3}");
Console.WriteLine($"The range of short type is {max4} to {min4}");
*/



//Write a code that calculate the area of circle whose radius is 2.50 centimeter.

// Sol:

/* double radius = 2.50;
 double area = Math.PI * radius * radius;
 Console.WriteLine(area);
*/

// Branches (IF) Condition (return -- (True/False)

/* int a = 5;
 int b = 4;
 if (a + b > 10) 
 Console.WriteLine("The answer is greater than 10.");
 else
     Console.WriteLine("The answer is not greater than 10.");*/



/* int a = 4;
 int b = 6;
 int c = 8;
 if ((a + b + c > 10) || (a == b))
 {
     Console.WriteLine("The answer is greater than 10.");
     Console.WriteLine("And the first number is equal to second number");
 }
 else
 {
     Console.WriteLine("The answer is not greater than 10.");
     Console.WriteLine("And the first number is not equal to second number");
 }*/




// Loops (Using loop to repeat the statement.)
/*
        int counter = 100;
        while (counter > 0)
        {
            Console.WriteLine($"Hello World! The Counter is {counter}");
            counter--;
        }*/



internal class Program
{
    private static void Main(string[] args)
    {
        /* int counter = 0;
         do
         {
             Console.WriteLine($"The counter is {counter}.");
             counter++;
         } while (counter < 10);*/



        /*
                int i = 0;

                do
                {
                    Console.WriteLine("i = {0}", i);
                    i++;

                } while (i < 11);*/


        /*
                int i = 0;

                do
                {
                    Console.WriteLine("i = {0}", i);
                    i++;

                    if (i > 7)
                        break;

                } while (i < 10);*/


        /* for (int index = 0; index < 10; index++)
         {
             Console.WriteLine($"The Hello World! is {index}");

         }*/



        // Cobining Branches and loops 

        /*int sum = 0;
        for (int i =1; i < 20; i++)
        {
            if (i % 3 == 0)
            {
                sum++;
            }
        }
        Console.WriteLine($"The sum is {sum}.");*/

        Console.Write("Enter your name:  ");
        string name = Console.ReadLine();
        Console.Write("Enter Your Age: ");
        string age = Console.ReadLine();
        Console.WriteLine("Hello" + " " + name + " " + "your age is " + " " + age + ".");








    }
}