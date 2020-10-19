﻿using DataAccessLibrary.Models;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DataBindingApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public PersonVievModel VievModel { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            VievModel = new PersonVievModel();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var context = ((FrameworkElement)sender).DataContext;
            (DataContext as PersonVievModel)?.RemoveItem((Person)context);
        }
    }
}
