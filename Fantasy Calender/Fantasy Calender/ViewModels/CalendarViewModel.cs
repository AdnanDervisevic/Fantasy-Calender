using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Calender.ViewModels
{
    class CalendarViewModel
    {
        private DateTime displayDate;

        public DateTime DisplayDate
        {
            get
            {
                return displayDate;
            }
            set
            {
                if(value != displayDate)
                {
                    displayDate = value;
                }
            }
        }
            
    }
}
