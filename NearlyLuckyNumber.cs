// using System.Linq;
// using System;

// namespace app
// {
//     static class NearlyLuckyNumber
//     {
//         static void Main()
//         {
//             string s = Console.ReadLine();
//             Int64[] t = s.ToCharArray().Select(x => Convert.ToInt64(x.ToString())).ToArray();
//             string l = "NO";
//             int total = 0;
//             for(int i = 0; i < t.Length; i++){
//                 if(t[i] == 4 || t[i] == 7){
//                     total++;
//                 }
//             }
//             if(total == 4 || total == 7){
//                 l = "YES";
//             }
//             Console.Write(l);
//         }
//     }
// }