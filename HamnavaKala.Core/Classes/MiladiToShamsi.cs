using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.Classes
{
    public static class MiladiToShamsi
    {
        public static string ConvertDate(this DateTime dateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            var Date = pc.GetYear(dateTime).ToString("0000") + "/" + pc.GetMonth(dateTime).ToString("00") + "/" + pc.GetDayOfMonth(dateTime).ToString("00");
            return Date;
        }
    }
}
