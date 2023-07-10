// using System.Linq;
// using System;

// namespace app
// {
//     static class NextRound
//     {
//         static void Main()
//         {
//             string p = Console.ReadLine();
//             int n = Convert.ToInt32(p.Split(" ").First());
//             int s = Convert.ToInt32(p.Split(" ").Last());
//             if(s <= n && n <= 50 && s <= 50){
//                 int nop = 0;
//                 string st = Console.ReadLine();
//                 int[] v = st.Split(" ").Select(x => int.Parse(x)).ToArray();
//                 for (int i = 0; i < n; i++)
//                 {
//                     if(v[i] >= v[s-1] && v[i]>0 && v[i] <= 100){
//                         nop++;
//                     }
//                 }
//                 Console.Write(nop);
//             }
//         }
//     }
// }