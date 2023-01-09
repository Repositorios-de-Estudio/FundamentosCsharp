using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas_datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Fecha y hora actual: " + DateTime.Now);

            DateTime dt = new DateTime(2023, 1, 7, 5, 24, 00 );
            DateTime dt2 = new DateTime(2022, 1, 7, 5, 24, 00);

            Console.WriteLine(dt.Year);
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Day);
            Console.WriteLine(dt.DayOfYear);
            Console.WriteLine(dt.DayOfWeek);

            // suma de dias, años, meses, etc..
            Console.WriteLine(dt.AddDays(90));

            // resta de dias, años, meses, etc..
            Console.WriteLine(dt.AddDays(-90));

            // restar dos fechas
            Console.WriteLine(dt.Subtract(dt2));

        }
    }
}
