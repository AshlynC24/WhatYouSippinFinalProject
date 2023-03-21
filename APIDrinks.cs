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

            //var strdrink = drinkObject["drinks"][0]["strDrink"].ToString();
            //var pic = drinkObject["drinks"][0]["strDrinkThumb"].ToString();
            //var link = url.Contains("https://recipes.cocktailpro.app/cocktail/529128f1-d75f-11e8-b879-ede987b3cdac/110%20in%20the%20shade");


            //var list = new List<Drink>();

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


        //      public static void callAPI(string input)
        //{
        //	switch (input.ToLower())//This also has to read the input as user input make it the same variable for the controller 
        //	{
        //		case "tequila":
        //			callTequila();
        //                  break;

        //		case "gin":
        //			callGin();
        //                  break;

        //		case "vodka":
        //			callVodka();
        //                  break;

        //		case "rum":
        //			callRum();
        //                  break;

        //		case "whiskey":
        //			 callWhiskey();
        //                  break;

        //		case "bourbon":
        //			 callBourbon();
        //                  break;

        //		default:
        //			callTequila();
        //                  break;//This is printing the default currently 


        //	}
        //}


        //      public static IEnumerable<Drink> callTequila()
        //      {
        //          var client = new HttpClient();
        //          string ingredient = "tequila";

        //          var url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?i={ingredient}";
        //          var response = client.GetStringAsync(url).Result;
        //          var drinkObject = JObject.Parse(response);


        //          //var strdrink = drinkObject["drinks"][0]["strDrink"].ToString();
        //          //var pic = drinkObject["drinks"][0]["strDrinkThumb"].ToString();
        //          //var link = url.Contains("https://recipes.cocktailpro.app/cocktail/529128f1-d75f-11e8-b879-ede987b3cdac/110%20in%20the%20shade");




        //          throw new NotImplementedException();

        //      }

        //public static Drink callGin(string drinkType)
        //{
        //	var client = new HttpClient();
        //	string ingredient = "gin";

        //	var url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?i={ingredient}";
        //	var response = client.GetStringAsync(url).Result;
        //	var drinkObject = JObject.Parse(response);

        //	var strdrink = drinkObject["drinks"][0]["strDrink"].ToString();
        //	var pic = drinkObject["drinks"][0]["strDrinkThumb"].ToString();



        //	//var root = JsonConvert.DeserializeObject<Drink>(response);
        //	return new Drink()
        //	{
        //		strDrink = strdrink,
        //		strDrinkThumb = pic
        //	};
        //}

        //      public static Drink callVodka()
        //      {
        //          var client = new HttpClient();
        //          string ingredient = "vodka";

        //          var url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?i={ingredient}";
        //          var response = client.GetStringAsync(url).Result;
        //          var drinkObject = JObject.Parse(response);

        //          var strdrink = drinkObject["drinks"][0]["strDrink"].ToString();
        //          var pic = drinkObject["drinks"][0]["strDrinkThumb"].ToString();



        //          //var root = JsonConvert.DeserializeObject<Drink>(response);
        //          return new Drink()
        //          {
        //              strDrink = strdrink,
        //              strDrinkThumb = pic
        //          };
        //      }

        //      public static Drink callWhiskey()
        //      {
        //          var client = new HttpClient();
        //          string ingredient = "whiskey";

        //          var url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?i={ingredient}";
        //          var response = client.GetStringAsync(url).Result;
        //          var drinkObject = JObject.Parse(response);

        //          var strdrink = drinkObject["drinks"][0]["strDrink"].ToString();
        //          var pic = drinkObject["drinks"][0]["strDrinkThumb"].ToString();



        //          //var root = JsonConvert.DeserializeObject<Drink>(response);
        //          return new Drink()
        //          {
        //              strDrink = strdrink,
        //              strDrinkThumb = pic
        //          };
        //      }

        //      public static Drink callBourbon()
        //      {
        //          var client = new HttpClient();
        //          string ingredient = "bourbon";

        //          var url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?i={ingredient}";
        //          var response = client.GetStringAsync(url).Result;
        //          var drinkObject = JObject.Parse(response);

        //          var strdrink = drinkObject["drinks"][0]["strDrink"].ToString();
        //          var pic = drinkObject["drinks"][0]["strDrinkThumb"].ToString();



        //          //var root = JsonConvert.DeserializeObject<Drink>(response);
        //          return new Drink()
        //          {
        //              strDrink = strdrink,
        //              strDrinkThumb = pic
        //          };
        //      }
        //      public static Drink callRum()
        //      {
        //          var client = new HttpClient();
        //          string ingredient = "rum";

        //          var url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?i={ingredient}";
        //          var response = client.GetStringAsync(url).Result;
        //          var drinkObject = JObject.Parse(response);

        //          var strdrink = drinkObject["drinks"][0]["strDrink"].ToString();
        //          var pic = drinkObject["drinks"][0]["strDrinkThumb"].ToString();



        //          //var root = JsonConvert.DeserializeObject<Drink>(response);
        //          return new Drink()
        //          {
        //              strDrink = strdrink,
        //              strDrinkThumb = pic
        //          };
        //      }
        //      public static void callurl(string url)
        //      {
        //          WebRequest request = HttpWebRequest.Create(url);
        //          WebResponse response = request.GetResponse();
        //          StreamReader reader = new StreamReader(response.GetResponseStream());
        //          string urlText = reader.ReadToEnd(); // it takes the response from your url. now you can use as your need  

        //      }
    }
}

