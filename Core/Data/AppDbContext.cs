using Core.Helpers.Enums;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
	public class AppDbContext
	{
		static List<Country> countryes = new List<Country>();
		static List<Planet> planets = new List<Planet>();
		//CreateCountry()
		public static void CreateCountry(Country country)
		{
			countryes.Add(country);
		//CreatePlanet()
		}
		public static void CreatePlanet(Planet planet)
		{
			planets.Add(planet);
		}
		//UpdateCountry()
		public static void UpdateCountry(int UpdatedountryId,String UpdatedCounteryName)
		{
			foreach (Country country in countryes)
			{
				if (country.CounteryId == UpdatedountryId)
				{
					country.CountryName = UpdatedCounteryName;
				}
			}
		}


		//RemoveCountry()
		public static void RemoveCountry(int id)
		{
			Country country = countryes.Find(x => x.CounteryId == id);
			countryes.Remove(country);
		}

		//GetAllCountries()
		public static void GetAllCountries()
		{
			foreach (Country country in countryes)
			{
				Console.WriteLine(country);
			}
		}
		//GetCountryByRegion()
		public static void GetCountryByRegion(string region)
		{
			 
			foreach (var country in countryes)
			{
				if (country.Region.ToString() == region)
				{
                    Console.WriteLine(country);
				}
			}
		}

	
	

		//2.Butun Planetleri gor
		//public void ShowPlanetsInfo()
		//{
		//Console.WriteLine(planets);
		//}

		//UpdatePlanet()

		public static void UpdatePlanet(int UpdatedPlanetId,string UpdatedPlanetName)
		{
			foreach (Planet planet in planets)
			{
				if (planet.PlanetId == UpdatedPlanetId)
				{
					planet.Name = UpdatedPlanetName;
				}
			}
		}


		//RemovePlanet()
		public static void RemovePlanet(int id)
		{
			Planet planet = planets.Find(x => x.PlanetId == id);
			planets.Remove(planet);
		}

		//GetAllPlanets()
		public static void GetAllPlanets()
		{
			foreach(Planet planet in planets)
			{
				Console.WriteLine(planet.ShowInfo());
			}
		}
		public static bool GetPlanet(string NAME)
		{
			bool result = false;
			foreach (Planet planet in planets)
			{
				if (NAME == planet.Name)
				{
					result = true;
				}

			}
			return result;
		}
		
	
	}
}
