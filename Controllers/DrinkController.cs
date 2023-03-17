//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using WhatYouSippin_FinalProject.Models;
//using static WhatYouSippin_FinalProject.Models.Drink;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace WhatYouSippin_FinalProject.Controllers
//{
    //public class DrinkController : Controller
    //{
        // GET: /<controller>/
        //public IActionResult Index()
        //{
            //var client = new HttpClient();
            //string ingredient = "Vodka";

            //var url = $"https://www.thecocktaildb.com/api/json/v1/1/filter.php?i={ingredient}";
            //var response = client.GetStringAsync(url).Result;
            //var drinkObject = JObject.Parse(response);

           // var drink = new Drink()
            //{
              //  strDrink = drinkObject["drinks"][0]["strDrink"].ToString(),
                //strDrinkThumb = drinkObject["drinks"][0]["strDrinkThumb"].ToString()
           // };

            //what is this doing? 


            //var root = JsonConvert.DeserializeObject<Drink>(response);
           // return View(drink);
        //}
   // }//
//}

