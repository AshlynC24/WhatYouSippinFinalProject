using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WhatYouSippin_FinalProject.Models;
using System.Net;
using System.IO;


namespace WhatYouSippin_FinalProject
{
	public static class APIDrinks
    {

        public static Root GetDrinks(string alcoholType)
        {
            var client = new HttpClient();
            var url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?i={alcoholType}";
            var response = client.GetStringAsync(url).Result;

            var root = JsonConvert.DeserializeObject<Root>(response);

            return root;

        }
        public static Root GetDrinkInfo(int id)
        {
            var client = new HttpClient();
            var url = $"https://www.thecocktaildb.com/api/json/v1/1/lookup.php?i={id}";
            var response = client.GetStringAsync(url).Result;

            var drink = JsonConvert.DeserializeObject<Root>(response);

            return drink;
        }
    }
}

