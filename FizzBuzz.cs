using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{
    public static void fizzBuzz(int n)
    {
        if (n % 3 == 0 && n % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if ( n % 3 == 0)
        {
            Console.WriteLine("Fizz");            
        }
        else if ( n % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(n);
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.Write("Deger girin: ");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.fizzBuzz(n);
    }
}
