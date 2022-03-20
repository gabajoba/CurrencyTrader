using CurrencyTrader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyTrader.ViewModels
{
    class CalculatorViewModel : BaseViewModel
    {
        private int firstValuteValue;
        private int secondValuteValue;
        private Valute firstValute;
        private Valute secondValute;

        public int FirstValuteValue
        {
            get
            {
                return firstValuteValue;
            }
            set
            {
                firstValuteValue = value;
                OnPropertyChanged("FirstValuteValue");
            }
        }
        public int SecondValuteValue
        {
            get
            {
                return secondValuteValue;
            }
            set
            {
                secondValuteValue = value;
                OnPropertyChanged("SecondValuteValue");
            }
        }
        public Valute FirstValute
        {
            get
            {
                return firstValute;
            }
            set
            {
                firstValute = value;
                OnPropertyChanged("FirstValute");
            }
        }
        public Valute SecondValute
        {
            get
            {
                return secondValute;
            }
            set
            {
                secondValute = value;
                OnPropertyChanged("SecondValute");
            }
        }
    }
}
