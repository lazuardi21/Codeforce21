// using System.Linq;
// using System;

// namespace app
// {
//     static class BeautifulMatrix
//     {
//         static void Main()
//         {
//             int[,] x = new int[5, 5];
//             int[]y;
//             int u = 0;
//             int v = 0;
//             bool d = false;
//             int n = 5;
//             int step = 0;
//             for(int i = 0; i < n; i++){
//                 string s = Console.ReadLine();
//                 y = s.Split(" ").Select( k => int.Parse(k)).ToArray();
//                 foreach (var item in y.Select((data, i) => new { data, i }))
// 					{
//                          x[i, item.i] = item.data;
//                     }
//             }
//             for(int i = 0; i < n; i++){
//                 for(int j = 0; j < n; j++){
//                     if(x[i, j] == 1){
//                         u = i;
//                         v = j;
//                         d = true;
//                         break;
//                     }
//                 }
//                 if(d){
//                     break;
//                 }
//             }
//             step += Math.Abs(2 - u);
//             step += Math.Abs(2 - v);
//             Console.Write(step);
//         }
//     }
// }