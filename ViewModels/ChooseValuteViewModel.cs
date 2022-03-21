using CurrencyTrader.Commands;
using CurrencyTrader.Data;
using CurrencyTrader.Models;
using CurrencyTrader.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CurrencyTrader.ViewModels
{
    class ChooseValuteViewModel : BaseViewModel
    {
        public static ChooseValuteViewModel Instance;
        public ObservableCollection<Valute> CurrencyList { get; private set; }
        public ChoosedValute ChoosedValute;

        public ChooseValuteViewModel()
        {
            if(Instance == null)
            {
                Instance = this;
            }
            CurrencyList = CurrencyData.CurrencyList;
            ChoosedValute = ChoosedValute.First;
        }
        public static void ChooseValute(string charCode)
        {
            MainViewModel.Instance.SelectedPage = new CalculatorPageView();
            if (Instance.ChoosedValute == ChoosedValute.First)
            {
                CalculatorViewModel.Instance.FirstValute = CurrencyData.CurrencyList.Where(x => x.CharCode == charCode).First();
            }
            else if (Instance.ChoosedValute == ChoosedValute.Second)
            {
                CalculatorViewModel.Instance.SecondValute = CurrencyData.CurrencyList.Where(x => x.CharCode == charCode).First();    
            }
        }
    }
}
