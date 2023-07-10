// using System.Linq;
// using System;

// namespace app
// {
//     static class SoldierAndBananas
//     {
//         static void Main()
//         {
//             string s = Console.ReadLine();
//             List<int> t = s.Split(" ").Select(x => int.Parse(x)).ToList();
//             int k = t[0];
//             int n = t[1];
//             int w = t[2];
//             int total = 0;
//             int a = 0;

//             for(int i = 1; i <= w; i++){
//                 a += k*i;
//             }
//             total = n - a > 0 ? 0 : a - n;
//             Console.Write(total);
//         }
//     }
// }