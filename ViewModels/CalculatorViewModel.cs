using CurrencyTrader.Commands;
using CurrencyTrader.Models;
using CurrencyTrader.Views;
using System;
using System.Windows.Input;

namespace CurrencyTrader.ViewModels
{
    public enum ChoosedValute
    {
        First,
        Second
    }
    class CalculatorViewModel : BaseViewModel
    {
        public static CalculatorViewModel Instance;
        private double firstValuteValue;
        private double secondValuteValue;
        private string firstValuteName;
        private string secondValuteName;
        private static Valute firstValute;
        private static Valute secondValute;
        public CalculatorViewModel()
        {
            if(Instance == null)
            {
                Instance = this;
            } 
        }

        public double FirstValuteValue
        {
            get
            {
                return Math.Round(firstValuteValue,2);
            }
            set
            {
                firstValuteValue = value;
                OnPropertyChanged("FirstValuteValue");
            }
        }
        public double SecondValuteValue
        {
            get
            {
                return Math.Round(secondValuteValue, 2);
            }
            set
            {
                secondValuteValue = value;
                OnPropertyChanged("SecondValuteValue");
            }
        }
        public string FirstValuteName
        {
            get
            {
                return firstValuteName;
            }
            set
            {
                firstValuteName = value;
                OnPropertyChanged("FirstValuteName");
            }
        }
        public string SecondValuteName
        {
            get
            {
                return secondValuteName;
            }
            set
            {
                secondValuteName = value;               
                OnPropertyChanged("SecondValuteName");
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
                FirstValuteName = value.CharCode;
                FirstValuteValue = value.Value;              
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
                SecondValuteName = value.CharCode;
                SecondValuteValue = value.Value;

                OnPropertyChanged("SecondValute");
            }
        }

        public ICommand ChangeFirstValuteBtnClicked
        {
            get
            {
                return new DelegateCommand(ChangeFirstValute);
            }
        }
        public ICommand ChangeSecondValuteBtnClicked
        {
            get
            {
                return new DelegateCommand(ChangeSecondValute);
            }
        }

        public void ChangeFirstValute()
        {
            MainViewModel.Instance.SelectedPage = new ChooseValutePageView();
            ChooseValuteViewModel.Instance.ChoosedValute = ChoosedValute.First;
        }
        public void ChangeSecondValute()
        {
            MainViewModel.Instance.SelectedPage = new ChooseValutePageView();
            ChooseValuteViewModel.Instance.ChoosedValute = ChoosedValute.Second;
        }

    }
}
