// using System;

// namespace app
// {
//     static class Team
//     {
//         static void Main()
//         {
//             int n = Convert.ToInt32(Console.ReadLine());
//             int t = 0;
//             for(int i = 0; i < n; i++)
//             {
//                 int u = 0;
//                 string[] s = Console.ReadLine().Split(" ");
//                 foreach(string y in s){
//                     u += Convert.ToInt32(y);
//                 }
//                 if(u > 1){
//                     t++;
//                 }
//             }
//             Console.Write(t);
//         }
//     }
// }