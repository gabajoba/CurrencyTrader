﻿using CurrencyTrader.Data;
using CurrencyTrader.Models;
using CurrencyTrader.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace CurrencyTrader.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class CalculatorPageView : Page
    {
        public CalculatorPageView()
        {
            this.InitializeComponent();
        }

        private void TextBeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        {

                args.Cancel = args.NewText.Any(c => (!char.IsDigit(c)));

        }
    }
}
