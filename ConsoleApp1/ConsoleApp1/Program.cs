using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

class Solution
{
	public static List<Toppings> LoadJson()
	{
		List<Toppings> toppings = null;
		WebClient client = new WebClient();
		Stream stream = client.OpenRead("http://files.olo.com/pizzas.json");
		using (StreamReader r = new StreamReader(stream))
		{
			string json = r.ReadToEnd();
			toppings = JsonConvert.DeserializeObject<List<Toppings>>(json);
		}
		return toppings;
	}

	static void Main()
	{
		List<string[]> combos = new List<string[]>();
		List<Toppings> toppings = LoadJson();
		foreach (var topping in toppings)
		{
			if (topping.type.Length > 1)
			{
				combos.Add(topping.type);
			}
		}
	}

	public class Toppings
	{
		[JsonProperty("toppings")]
		public string[] type { get; set; }
	}
}


