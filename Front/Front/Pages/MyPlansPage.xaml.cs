﻿using Front.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FrontEnd.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPlansPage : ContentPage
    {
        MyPlansViewModel _vm = new MyPlansViewModel();
        public MyPlansPage()
        {
            BindingContext = _vm;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            _vm.GetPersonalPlans();
            base.OnAppearing();
        }
    }
}