using System.Linq;
using System;

namespace app
{
    static class Tram
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            int re = 0;
            for (int i = 0; i < n; i++){
                string s = Console.ReadLine();
                int o = Convert.ToInt32(s.Split(" ").First());
                int e = Convert.ToInt32(s.Split(" ").Last());
                max -= o;
                max += e;
                if(re < max){
                    re = max;
                }
            }
            Console.Write(re);
        }
    }
}