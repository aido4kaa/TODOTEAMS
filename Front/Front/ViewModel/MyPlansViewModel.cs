using Data.Models;
using Front.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Front.ViewModel
{
    internal class MyPlansViewModel
    {
        public ObservableCollection<Plan> Plans { get; set; }
        
        public async void GetPersonalPlans()
        {
            Plans = new ObservableCollection<Plan>(await new PlanService().GetPlans());
        }
    }
}
