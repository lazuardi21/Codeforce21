// using System.Linq;
// using System;

// namespace app
// {
//     static class AntonAndDanik
//     {
//         static void Main()
//         {
//             int n = Convert.ToInt32(Console.ReadLine());
//             string s = Console.ReadLine();
//             string[] t = s.ToCharArray().Select(x => x.ToString()).ToArray();
//             int aw = 0;
//             int dw = 0;
//             string r = "";
//             for(int i = 0; i < n; i++){
//                 if(t[i] == "A"){
//                     aw++;
//                 }
//                 else if(t[i] == "D"){
//                     dw++;
//                 }
//             }
//             if(aw > dw){
//                 r = "Anton";
//             }
//             else if(dw > aw){
//                 r = "Danik";
//             }
//             else if(aw == dw){
//                 r = "Friendship";
//             }
//             Console.Write(r);
//         }
//     }
// }