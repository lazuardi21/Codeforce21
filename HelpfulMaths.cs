// using System.Linq;
// using System;

// namespace app
// {
//     static class HelpfulMath
//     {
//         static void Main()
//         {
//             string s = Console.ReadLine();
//             int[] t = s.Split("+").Select(x => int.Parse(x)).OrderBy(x => x).ToArray();
//             string u = string.Join("+", t);
//             Console.Write(u);
//         }
//     }
// }