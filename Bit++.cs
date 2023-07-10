// using System.Linq;
// using System;

// namespace app
// {
//     static class BitPlusPlus
//     {
//         static void Main()
//         {
//             int v = 0;
//             int n =  Convert.ToInt32(Console.ReadLine());
//             if(n >= 1 && n <= 150){
//                 for(int i = 0; i < n; i++){
//                     string a = Console.ReadLine();
//                     if(a.Contains("++") && a.Contains("X") && a.Length == 3){
//                         v++;
//                     }
//                     else if(a.Contains("--")&& a.Contains("X") && a.Length == 3){
//                         v--;
//                     }
//                 }
//             }
//             Console.Write(v);
//         }
//     }
// }