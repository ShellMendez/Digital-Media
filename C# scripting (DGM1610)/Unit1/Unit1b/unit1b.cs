using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome");
        DoMath(10,5);
        DoMath(20,5);
        DoMath(30,5);
        Compare(4,3);
        Compare(3,4);
        CheckPassword("SevenLions");
        CheckPassword("OUI812");


    }
    static void DoMath(int value , int value2)
{
    var number = value + value2;
    Console.WriteLine(number);

}
    static void Compare (int value ,  int value2)
    {
        if (value > value2)
        {
            Console.WriteLine("True the first is greater");

        }
        else
        {
            Console.WriteLine("False");
        }

    }
        static void CheckPassword(string password) {
        if (password == "OUI812"){
            Console.WriteLine("Correct Password");

        }
        else 
        {
            Console.WriteLine("Incorrect");

        }
        string checkingvar = (password != "OUI812")? "True" : "False";
        Console.WriteLine(checkingvar);
    }
}