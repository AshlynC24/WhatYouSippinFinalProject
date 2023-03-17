using System;
namespace WhatYouSippin_FinalProject.Models
{

        public class Drink
        {
            public string? strDrink { get; set; }
            public string? strDrinkThumb { get; set; }
            public string? idDrink { get; set; }

        public List<string>? options { get; set; } = new List<string>() { "Tequila", "Vodka", "Rum", "Gin", "Whiskey", "Bourbon" };

        }

        //public class Root
        //{
          //  public List<Drink> drinks { get; set; }
        //}



    
}

