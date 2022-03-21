using CurrencyTrader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace CurrencyTrader.Data
{
    abstract class CurrencyData
    {
        private const string URL = "https://www.cbr-xml-daily.ru/daily_json.js";
        private static DateTime _dateTime;
        private static ObservableCollection<Valute> _currencyList = new ObservableCollection<Valute>();

        public static DateTime CurrentDateTime
        {
            get 
            { 
                return _dateTime;
            }
            set
            { 
                RefreshCurrency();
            }
        }
        public static ObservableCollection<Valute> CurrencyList
        {
            get 
            {
                return _currencyList; 
            }
            set 
            { 
                RefreshCurrency(); 
            }
        }

        public static async void RefreshCurrency()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var json = await (await httpClient.GetAsync(URL)).Content.ReadAsStringAsync();
                    CurrencyList test = JsonConvert.DeserializeObject<CurrencyList>(json);
                    _dateTime = test.Date;
                    foreach(var temp in test.Valute)
                    {
                        CurrencyList.Add(temp.Value);
                    }
                }

            } catch(Exception e)
            {
                throw e;
            }
        }
    }
}
