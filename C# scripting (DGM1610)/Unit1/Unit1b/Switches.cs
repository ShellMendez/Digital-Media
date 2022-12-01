// using System;
// public class Program
// {
//     public GameStates gameStates;

//     public static void Main()
//     {
//         gameStates = new GameStates();
//         gameStates.CheckState();
//         Console.WriteLine("Hello World");
//     }
    
// }
// public class GamesStates 
// {
//     public enum States 
//     {
//         //Think of it as labels 
//         Starting,
//         Playing,
//         Ending,

//     }
//     public States currentState = States.Starting;
//     public static void CheckState()
//     {
//         switch (currentState)
//         {
//             case States.Starting:
//                 Console.WriteLine("Starting");
//                 break;
//             // case States.Playing:

//         }
//     }

// }
using System;
using System.Collections.Generic;

// class Program {
//    static void Main() {
//       string val;
//       int res;
   
//       Console.WriteLine("Input from user: ");
//       val = Console.ReadLine();

//       // convert to integer
//       res = Convert.ToInt32(val);

//       // display the line
//       Console.WriteLine("Input = {0}", res);
//    }



   class Program {

      static void Main() {   
         int grade = 90;      
         switch (grade) {
            case 50:
               Console.WriteLine("Failed");
               break;
            case 60:
            case 70:
               Console.WriteLine("Got a C");
               break;
            case 80:
               Console.WriteLine("Got a B");
               break;
            case 90:
               Console.WriteLine("Got a A");
               HonorStudent();
               break;

            default:
            Console.WriteLine("Invalid grade");
               break;
         }

      }
   
      static void HonorStudent(){
      Console.WriteLine("You did amazing");

   }
   }






// }