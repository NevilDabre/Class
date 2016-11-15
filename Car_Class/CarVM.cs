//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class
{
    class CarVM : INotifyPropertyChanged
    {
        private string _error,_make,_year;
        private int _speed;

        public CarVM(string year, string make)
        {
            // TODO: Complete member initialization
            this._year = year;
            this._make = make;
        }
        
        public string Error
        {
            get { return _error; }
            set { _error = value; OnPropertyChanged(); }
        }

        public string Make
        {
            get { return _make; }
            set { _make = value; OnPropertyChanged(); }
        }

        public string Year
        {
            get { return _year; }
            set { _year = value; OnPropertyChanged(); }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; OnPropertyChanged(); }
        }



        public void Accelerate()
        {
            Error = string.Empty;
            Speed = Speed + 5;
        }

        public void Brake()
        {
            Error = string.Empty;
            if (Speed < 5)
            {
                Error = "Car Stopped";
            }
            else
            {
                Speed = Speed - 5;
            }
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
