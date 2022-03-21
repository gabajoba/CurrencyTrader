using CurrencyTrader.Commands;
using CurrencyTrader.Data;
using CurrencyTrader.Models;
using CurrencyTrader.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace CurrencyTrader.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private Page _selectedPage;

        public Page SelectedPage
        {
            get { return _selectedPage; }
            set
            {
                _selectedPage = value;
                OnPropertyChanged(nameof(SelectedPage));
            }

        }
        public static MainViewModel Instance;
        public MainViewModel()
        {
            if(Instance == null)
            {
                Instance = this;
                SelectedPage = new CalculatorPageView();
                CurrencyData.CurrencyList = null;
            }
        }

    }
}
