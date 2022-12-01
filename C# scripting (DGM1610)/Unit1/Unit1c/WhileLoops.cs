using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        int xy = 1;

        while (x <= 5 && x != 3 || x == 2)
        {
            x++;
            Console.WriteLine("5");
        }
  
        do
        {  Console.WriteLine(xy);
           xy++;
     

        }
        while (xy != 8 );
 
        	Console.WriteLine("This is the end of the Do While Loop");

    }
}
