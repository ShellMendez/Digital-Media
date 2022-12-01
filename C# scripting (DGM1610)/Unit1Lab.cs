using System;
using System.Diagnostics;

//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

//Based on the HelloWorld File, turn this into a class.

//Write a console program with a program class, and Main Function

//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables
// using System;
// using CorrectTheErrors;
// public class Lab1{
// public static void Main()
// {

//     Console.WriteLine("Hello It works");
// }
// }

class Operators 

{

  public int x = 100;
  public int y = 5;
  public string str1 = "this is a string.";
  public float flt1 = 1.2f;


    public void Addition()
    {
        int theSum = x + y;
        int sum1 = x +1;
        sum1 += 100;


        Console.WriteLine(sum1);
        
    }
    public void Subtration()
    {
        int sub1 = x-y;
        Console.WriteLine(sub1);
    
    }
    public void Division()
    {
        int div1 = x/y;
        Console.WriteLine(div1);
        Console.WriteLine(div1 +=100);
        Console.WriteLine("It worked as it should");
        bool DivisionSelected = true;
        Console.WriteLine(str1);
        Console.WriteLine(DivisionSelected);
        Console.WriteLine(flt1)
        Remainder();


    }
    public void Remainder()
    {
        Console.WriteLine("And the remainder is");

        int remain = x%y;
        Console.WriteLine(remain);


    }
    public void Compare()
    {
        Console.WriteLine("We are comparing now");
        Console.WriteLine(x<7);
        Console.WriteLine(x>y);


    }
}

class Program
    {
    static void Main(string[] args)
    {
      Operators myObj = new Operators();
        myObj.Addition();
        myObj.Subtration();
        myObj.Division();
        myObj.Compare();
        SwitchStatement();
    }


   
        public string selection = "Yellow";

        void SwitchStatement(Collision other)
        {

            switch (selection)
            {
                case ("Blue"):
                    Debug.Log("It is  Blue");
                    break;
                case ("Yellow"):
                    Debug.Log("It is Yellow");
                    break;
                case ("Pink"):
                    Debug.Log("It is Pink");
                    break;
            }
        }

    }




}
  }


