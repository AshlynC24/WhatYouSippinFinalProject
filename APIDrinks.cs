using System;
using Newtonsoft.Json.Linq;
using WhatYouSippin_FinalProject.Models;

namespace WhatYouSippin_FinalProject
{
	public static class APIDrinks
	{
		public static Drink callAPI(string liquor)
		{
			switch (liquor.ToLower())
			{
				case "tequila":
					return callTequila();
					break;
				case "gin":
					return callGin();
					break;
				case "vodka":
					return callVodka();
					break;
				case "rum":
					return callRum();
					break;
				case "whiskey":
					return callWhiskey();
					break;
				case "bourbon":
					return callBourbon();
					break;
				default:
					return callTequila();
					break;

			}
		}


		public static Drink callTequila()
		{
            var client = new HttpClient();
            string ingredient = "Tequila";

            var url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?i={ingredient}";
            var response = client.GetStringAsync(url).Result;
            var drinkObject = JObject.Parse(response);

			var strdrink = drinkObject["drinks"][0]["strDrink"].ToString();
			var pic = drinkObject["drinks"][0]["strDrinkThumb"].ToString();



			//var root = JsonConvert.DeserializeObject<Drink>(response);
			return new Drink()
			{
				strDrink = strdrink,
				strDrinkThumb = pic
			};
        }

		public static Drink callGin()
		{
			var client = new HttpClient();
			string ingredient = "Gin";

			var url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?i={ingredient}";
			var response = client.GetStringAsync(url).Result;
			var drinkObject = JObject.Parse(response);

			var strdrink = drinkObject["drinks"][0]["strDrink"].ToString();
			var pic = drinkObject["drinks"][0]["strDrinkThumb"].ToString();



			//var root = JsonConvert.DeserializeObject<Drink>(response);
			return new Drink()
			{
				strDrink = strdrink,
				strDrinkThumb = pic
			};
		}

        public static Drink callVodka()
        {
            var client = new HttpClient();
            string ingredient = "vodka";

            var url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?i={ingredient}";
            var response = client.GetStringAsync(url).Result;
            var drinkObject = JObject.Parse(response);

            var strdrink = drinkObject["drinks"][0]["strDrink"].ToString();
            var pic = drinkObject["drinks"][0]["strDrinkThumb"].ToString();



            //var root = JsonConvert.DeserializeObject<Drink>(response);
            return new Drink()
            {
                strDrink = strdrink,
                strDrinkThumb = pic
            };
        }

        public static Drink callWhiskey()
        {
            var client = new HttpClient();
            string ingredient = "whiskey";

            var url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?i={ingredient}";
            var response = client.GetStringAsync(url).Result;
            var drinkObject = JObject.Parse(response);

            var strdrink = drinkObject["drinks"][0]["strDrink"].ToString();
            var pic = drinkObject["drinks"][0]["strDrinkThumb"].ToString();



            //var root = JsonConvert.DeserializeObject<Drink>(response);
            return new Drink()
            {
                strDrink = strdrink,
                strDrinkThumb = pic
            };
        }

        public static Drink callBourbon()
        {
            var client = new HttpClient();
            string ingredient = "bourbon";

            var url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?i={ingredient}";
            var response = client.GetStringAsync(url).Result;
            var drinkObject = JObject.Parse(response);

            var strdrink = drinkObject["drinks"][0]["strDrink"].ToString();
            var pic = drinkObject["drinks"][0]["strDrinkThumb"].ToString();



            //var root = JsonConvert.DeserializeObject<Drink>(response);
            return new Drink()
            {
                strDrink = strdrink,
                strDrinkThumb = pic
            };
        }
        public static Drink callRum()
        {
            var client = new HttpClient();
            string ingredient = "rum";

            var url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?i={ingredient}";
            var response = client.GetStringAsync(url).Result;
            var drinkObject = JObject.Parse(response);

            var strdrink = drinkObject["drinks"][0]["strDrink"].ToString();
            var pic = drinkObject["drinks"][0]["strDrinkThumb"].ToString();



            //var root = JsonConvert.DeserializeObject<Drink>(response);
            return new Drink()
            {
                strDrink = strdrink,
                strDrinkThumb = pic
            };
        }
    }
}

