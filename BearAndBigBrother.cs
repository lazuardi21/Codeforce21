// using System.Linq;
// using System;

// namespace app
// {
//     static class BearAndBigBrother
//     {
//         static void Main()
//         {
//             string s = Console.ReadLine();
//             List<int> t = s.Split(" ").Select(x => int.Parse(x)).ToList();
//             int a = t[0];
//             int b = t[1];
//             int total = 0;
//             while(a <= b){
//                 a *= 3;
//                 b *= 2;
//                 total++;
//             }
//             Console.Write(total);
//         }
//     }
// }