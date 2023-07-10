// using System.Linq;
// using System;

// namespace app
// {
//     static class StonesOnTheTable
//     {
//         static void Main()
//         {
//             int n = Convert.ToInt32(Console.ReadLine());
//             string s = Console.ReadLine();
//             List<string> t = s.ToCharArray().Select(x => x.ToString()).ToList();
//             List<string> a = new List<string>();
//             int total = 0;
//             for(int i = 0; i < n - 1; i++)
//             {
//                 if (t[i] == t[i + 1])
//                 {
//                     total++;
//                 }
//             }
//             Console.Write(total);
//         }
//     }
// }