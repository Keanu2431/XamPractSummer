﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamPractSummer.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace XamPractSummer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}