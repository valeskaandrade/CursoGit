
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = DateTime.ParseExact("2003-11-06","yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact("2003-11-06 13:45:30", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine("d1: -" + d1 + "-"); //d1: -06/11/2003 00:00:00-
            Console.WriteLine("d2: -" + d2 + "-"); //d1: -06/11/2003 00:00:00-
        }
    }
}

