using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
     class Program
    {

        static void Main(string[] args)
        {

            WriteSomething();
            WriteSomethingSpecific("I am an atgument and am called from a method");
            Console.Read();
        }
    
            public static void WriteSomething()
            {

            Console.WriteLine("I am called from a method");
            


            }

             public static void WriteSomethingSpecific(string myText)

            {

            Console.WriteLine(myText);
            

            }


       }
}





//contsant as fileds
//const double PI = 3.14159265359;
//const int weeks = 52, months = 12;
//const string birthday = "05.16.1999";






// getting a int out of string or double out of string the same process
//string myString = "15";
//string mySecondString = "13";
//int num1 = Int32.Parse(myString);
//int num2 = Int32.Parse(mySecondString);
//int resultInt = num1 + num2;
//string result = myString + mySecondString;

//Console.WriteLine(resultInt);
//Console.Read();







// CONVERSION
//imicit conversion
// int num = 12390532;
//long bigNum = num;

//float myFloat = 13.37f;
// double myNewDouble = myFloat;


// double myDouble = 13.37;
// int myInt;
//explicit conversion
//cast double into int;
// myInt = (int)myDouble;

// typeConversion, changing float to string adding .tostting;
//string myString = myDouble.ToString(); // "13.37"
//string myFloatString = myFloat.ToString();
//bool sunIsShining = false;

//string myBoolString = sunIsShining.ToString();

//Console.WriteLine(myBoolString);
//Console.Read();

//using string and it events
//string myname = "Moe";
//string message = "My name is " + myname;
//string CapMessage = message.ToUpper();

//string lowerCaseMessage = message.ToLower();

//Console.WriteLine(lowerCaseMessage);
//Console.Read();








//Calculating:
//int num1 = 13;
//int num2 = 14;
//int sum = num1 + num2;

//double d1 = 3.5;
//double d2 = 1.337;
//double sumD = d1 + d2;

//float f1 = 3.5f;
//float f2 = 5.4f;
//float sumf = f1 + f2;
//Console.WriteLine("the sum of " + num1 + " and " + num2 + " is " + sum);
//Console.WriteLine("the sum of " + d1 + " and " + d2 + " is " + sumD);
//Console.WriteLine("the sum of " + f1 + " and " + f2 + " is " + sumf);