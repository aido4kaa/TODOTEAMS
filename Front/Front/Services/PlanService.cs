using Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Front.Services
{
    internal class PlanService
    {
        private string Url = "http://10.0.2.2:5000/app/Plan/";

        public async Task<List<Plan>> GetPlans()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            var result = await client.GetAsync(Url + $"GetAllPlans/{Preferences.Get("current_user_id","default_value")}");
            var plans = JsonConvert.DeserializeObject<List<Plan>>(await result.Content.ReadAsStringAsync());
            return (plans);
        }
    }
}
