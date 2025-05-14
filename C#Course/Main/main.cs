using System;

class MainProgram {
    public static void Main(string[] ___){
        // primitive 
        // int, long, uint, ulong
        const int number = 13; 
        Console.WriteLine(number);
        Console.WriteLine("Sonal");

        // Parsing
        string str = "123";
        Int32 num = int.Parse(str);
        Console.WriteLine(num);
        Console.WriteLine(num.GetType());

        // Type Casting 
        string str1 = "123";
        int number1 = Convert.ToInt32(str1);
        Console.WriteLine(str1);

        // Parsing is only done with string
        // Type Casting is done with any Data Type  
    }
}