using System;
using System.ComponentModel;

namespace Fantasy_Calender.ViewModels 
{
    class CalendarViewModel : INotifyPropertyChanged
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

                    RaisePropertyChanged(nameof(DisplayDate));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
