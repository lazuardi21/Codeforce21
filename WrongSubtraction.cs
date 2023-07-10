// using System.Linq;
// using System;

// namespace app
// {
//     static class WrongSubtraction
//     {
//         static void Main()
//         {
//             string s = Console.ReadLine();
//             int[] t = s.Split(" ").Select(x => int.Parse(x)).ToArray();
//             int n = t[0];
//             int k = t[1];
//             for (int i = 0; i < k; i++){
//                 if(n%10 != 0){
//                     n--;
//                 }
//                 else{
//                     n /= 10;
//                 }
//             }
//             Console.Write(n);
//         }
//     }
// }