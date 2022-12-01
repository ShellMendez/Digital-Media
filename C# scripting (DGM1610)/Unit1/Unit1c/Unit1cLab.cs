using System;
// class Program{
//      static void Main(){
//         string[] cars = {"Tesla","Toyota","BMW"};// This will indicate the computer it is an array.
//         Console.WriteLine(cars[1]);
//         Console.WriteLine(cars.Length);

//         foreach(string i in cars){
//             Console.WriteLine(i);
//         }

//     }
// }
// public class Program{
//     public static void Main()
//     {
//         string[] playerTypes = {"Pawn","Pawn","Pawn"};

//         for (var i = 0; i < playerTypes.Length;i++){
//             playerTypes[i] = "Queen";

//         }
//         foreach(var playerType in playerTypes){

//             Console.WriteLine(playerType);
//             Console.WriteLine(playerType);
            
//         }
//     }
// }
public class Program{
    public static void Main(){
        weapon[] weaponObjs = {new weapon() , new weapon(),new weapon()};
        weaponObjs[1].weaponName = "Sword";
        weaponObjs[2].weaponName = "Axe";
        
    
    for(var i=0; i < weaponObjs.Length;i++){
        weaponObjs[i].powerLevel = 2;
    }
        foreach (var item in weaponObjs){
            Console.WriteLine(item.weaponName);
            Console.WriteLine(item.powerLevel);


        }
    }
 }   

public class weapon{
    public string weaponName = "Axe";
    public int powerLevel = 1;
}