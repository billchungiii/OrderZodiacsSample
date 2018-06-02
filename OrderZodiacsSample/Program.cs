using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderZodiacsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list
               = new List<string> { "牛", "豬", "鼠", "羊", "狗" };

            foreach (var item in list.OrderBy((x) => x, new ZCompare()))
            { Console.WriteLine(item); }

            Console.WriteLine("test");
            Console.ReadLine();
        }

        public class ZCompare : IComparer<string>
        {
            private static List<string> zodiacs = new List<string>()
            {
                "鼠", "牛", "虎", "兔", "龍" , "蛇", "馬", "羊" , "猴", "雞", "狗", "豬"
            };
            public int Compare(string x, string y)
            {
                return (zodiacs.IndexOf(x) - zodiacs.IndexOf(y));
            }
        }
    }
}
