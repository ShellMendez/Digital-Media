//// }
//using System;

//namespace Loops
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //for (; ; )
//            //{
//            //    Console.WriteLine("Hey! I am Trapped");
//            //}
//        }
//    }
//}
//This Loop will create an infiniteLoop;
// // Hello World! program
using System;
using Internal;

class Class
{
    static void Main(string[] args)
    {
        int[] arrs1 = new int[] { 1, 2, 3, 4, 5, 6 };
        string HW = "Hello world";
        foreach (var item in arrs1)
        {
            Console.WriteLine(item);


        }
        foreach (char c in HW)
        {
            Console.WriteLine(c);
        }
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

    }
    /* **************OUTPUT 
---------First Loop
            2
            3
            4
            5
            6
--------Second Loop
            H
            e
            l
            l
            o
 
            w
            o
            r
            l
            d
 --------Third Loop
    */
}