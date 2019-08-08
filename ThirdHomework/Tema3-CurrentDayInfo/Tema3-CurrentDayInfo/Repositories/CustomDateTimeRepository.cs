using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tema3_CurrentDayInfo.Models
{
    public class CustomDateTimeRepository
    {
        readonly CustomDateTime _dateTime = new CustomDateTime
        {
            Day = DateTime.Today,
            Date = DateTime.Now
        };

        public CustomDateTime CurrentDateTime => _dateTime;
        
    }
}
