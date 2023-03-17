using System;
using WhatYouSippin_FinalProject.Models;

namespace WhatYouSippin_FinalProject
{
	public class UserInput
	{
		public Drink UserChoice()
		{
			Console.WriteLine("Choose your faveorite Liquor:");
			var input = Console.ReadLine();

			switch (input.ToLower())
			{
				case "Tequila":
					return APIDrinks.callTequila();
					break;
				case "Vodka":
					return APIDrinks.callVodka();
					break;
				case "Gin":
					return APIDrinks.callGin();
					break;
				case "Whiskey":
					return APIDrinks.callWhiskey();
					break;
				case "Bourbon":
					return APIDrinks.callBourbon();
					break;
				case "Rum":
					return APIDrinks.callRum();
					break;
				default:
					return APIDrinks.callTequila();
					break;
			}
			Console.ReadKey();
		} 
	}
}

