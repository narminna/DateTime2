using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Program
    {
        static void Main(string[] args)
        {
            string date;
            date=Console.ReadLine();
            DateTime dt = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime dt1 = dt.AddDays(30).AddHours(6).AddMinutes(17);
            Console.WriteLine(dt1);
        }
    }
}
