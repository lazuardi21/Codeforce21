// using System.Linq;
// using System;

// namespace app
// {
//     static class DominoPiling
//     {
//         static void Main()
//         {
//             string s = Console.ReadLine();
//             int m = Convert.ToInt32(s.Split(" ").First());
//             int n = Convert.ToInt32(s.Split(" ").Last());
//             int area = m * n;
//             int t = area%2 == 0 ? area/2 : Convert.ToInt32(Math.Floor(Convert.ToDouble(area/2)));
//             Console.Write(t);
//         }
//     }
// }