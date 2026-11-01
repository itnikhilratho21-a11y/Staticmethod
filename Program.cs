// See https://aka.ms/new-console-template for more information
using System;



/*

Console.WriteLine();
int[] number = new int[] { 1, 2, 45, 8 };
int highest = 0;
for(int i = 0; i < number.Length; i++)
{
    for (int j=i + 1; j < number.Length; j++)
    {
        if (number[j] > highest)
        {
            highest = number[j];
        }
    }
}
Console.WriteLine($"The highest number is: {highest}");

Console.WriteLine("Please enter a number to chech if it is prime or not");
int num = int.Parse(Console.ReadLine());

bool isPrime = true;

if (num <= 1)
{
    isPrime = false;
}
else
{
    for (int i=2; i<num; i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
            break;
        }
        
    }
}
if (isPrime)
{
    Console.WriteLine($"{num} is a Prime Number");
}
else
{
    Console.WriteLine($"{num} is Not a Prime Number");
Console.WriteLine("Please enter your name");
String name =Console.ReadLine();

String reversename =String.Empty;
for(int o = name.Length - 1; o >= 0; o--)
{
    reversename += name[o];
}
Console.WriteLine($"{reversename}");
}

String str = "Nikhil";
String reverse = String.Empty;

for(int i = str.Length - 1; i >= 0; i--)
{
    reverse += str[i];
}
if (str == reverse)
{
    Console.WriteLine("It is  a Palondrome");

}
else
{
    Console.WriteLine("It is not a palondrome");

}
String str = "Nikhill";
for(int i=0; i < str.Length; i++)
{
    for(int j=i+1;j< str.Length; j++)
    {
        if (str[i] == str[j])
        {
            Console.WriteLine($"Duplicate character is: {str[i]}");
            break;
        }
    }
}/
Console.WriteLine("Please enter  sentence ");
String sentence = Console.ReadLine();

string[] words = sentence.Split(' ');

Console.WriteLine("\n");

for(int i=0; i < words.Length; i++)
{
    Console.WriteLine(words[i]);
Console.WriteLine("Please enter a number");
int number= int.Parse(Console.ReadLine());

int eventCount =number/2 ;
int[] even = new int[eventCount];
int Counter = 2;
for (int i = 0; i < eventCount; i++,Counter +=2)
{
    even[i] = Counter;
}

for( int i=0; i< even.Length; i++)
{
    Console.WriteLine(even[i]);

}
Console.WriteLine("\n");
int[,] number = new int[3, 3];
for(int i =0; i < 3; i++)
{
    for(int j=0;j<3; j++)
    {
        Console.Write($"{i},{j}");
        
    }
    Console.WriteLine("\n");

}*/

namespace Static
{
    class Program
    {
        static void Main(string[] args)// calling method 
        {
            Console.WriteLine("Checking purpose");
            Console.WriteLine("We can weite the method");
            add();
            add1(5,10);
           String result= add2("Nikhil", "Rathod");
            Console.WriteLine($"{result}");
            int[] numbers = { 24, 2, 1, 4, 4 };
            sumofarray(numbers);


            //pass by value 
            int a = 5;
            Print(a);
           Console.WriteLine($"{a}");
            
            //ref 
            PrintA(ref a);
            Console.WriteLine($" ref {a}");

            //out 
            int b;int C; int D;
            PrintB(out b,out C, out D);
            Console.WriteLine($"{b} {C} {D}");

            //without return without parameter
            Console.ReadLine();
        }
        static void add()// called methhod 
        {
            Console.WriteLine("method call add()");


        }
        // without return with parameter 
        static void add1(int a, int b)
        {
            Console.WriteLine($"item of {a} and {b} = {a+b}");
        }
        static string add2(string Firstname, string Lastname)
        {
            return Firstname +" " + Lastname;

        }
        //sum of the array 

        static  void sumofarray(int[] numbers)
        {
            if(numbers!=null && numbers.Length > 0)
            {
                int sum = 0;
                for(int i=0;i<numbers.Length;i++) 
                {
                    sum += numbers[i];
                }
                Console.WriteLine($"sum of the array is  :{sum}");
                 

            }
            else
            {
                Console.WriteLine("Array is empty or null");
            }
              
            
        }
        static void Print(int a) // pass by value => any change called method will not changing calling method value
        {
            Console.WriteLine("This is static method");
            a= 1099;
        }
        static void PrintA(ref int a)
        {
            a = 99;
        }
        static void PrintB(out int b,out int C,out int D)
        {
            Console.WriteLine("This is out parmeter");
            b = 100;
            C = 200;
            D = b + C;
        }
        static void PrintC(params int[] numbers)
        {
            if(numbers !=null && numbers.Length > 0)
            {
                int sum = 0;
                for (int i=0;i<numbers.Length;i++)
                {
                    sum += numbers[i];
                    
                }Console.WriteLine($"{sum}");
            }
        }
    }

}