﻿using AppFood.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFood
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginViewPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
