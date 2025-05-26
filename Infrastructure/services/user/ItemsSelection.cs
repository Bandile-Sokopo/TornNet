using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models.User;
using Newtonsoft.Json;

namespace Infrastructure.services.user
{
    public class ItemsSelection : ISelection
    {
        HttpClient client = new() {BaseAddress = new Uri("https://api.torn.com")}; 
        public string key { set { key = ""; } }
        public string endpoint { set { key = "user"; } }
        public string selection { set { key = "items"; } }

        public async Task GetAsync(HttpClient sharedClient, string endpoint, string key, string selection)
        {
            using HttpResponseMessage response = await client.GetAsync($"{endpoint}/?selections={selection}&key={key}");

            Console.WriteLine(response.EnsureSuccessStatusCode());

            var jsonResponse = await response.Content.ReadAsStringAsync();

            User user = JsonConvert.DeserializeObject<User>(jsonResponse);


            Console.WriteLine($"{jsonResponse}\n");
        }
    }
}