using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"([A-Z]{2})(\d+(.\d+){0,1})([A-Za-z]+)\|";

            var input = Console.ReadLine();
            Dictionary<string,string> weatherInfos = new Dictionary<string, string>();

            var cityName = "";
            var temperature = 0.0;
            var typeOfWeather = "";
            var weatherInfo = "";

            while (input!="end")
            {

                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    cityName = match.Groups[1].Value;
                    temperature = double.Parse(match.Groups[2].Value);
                    typeOfWeather = match.Groups[4].Value;
                    weatherInfo = $"{temperature:f2} => {typeOfWeather}";
                }

                if (weatherInfos.ContainsKey(cityName)==false)
                {
                    weatherInfos.Add(cityName,"");
                }
                weatherInfos[cityName]=weatherInfo;
             

                input = Console.ReadLine(); 
            }

            foreach (var city in weatherInfos.OrderBy(x=>x.Value))
            {
                Console.WriteLine($"{city.Key} => { city.Value}");
            }

        }
    }
}
