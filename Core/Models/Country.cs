using Core.Helpers.Enums;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Core.Models
{
	public class Country
	{

		private static int _id =1;
		public int CounteryId { get; set; }
		public string CountryName { get; set; }
		public double Area { get; set; }
		public string Anthem { get; set; }
		public string REGION { get; set; }
		public Region Region { get; set; }

		public Country(string countryName, double area, string anthem, string region)
		{
			CounteryId = _id++;
			CountryName = countryName;
			Area = area;
			Anthem = anthem;
			REGION = region;
		}
		public string ShowInfo()
		{
			return $" Name: {CountryName}";
		}
		public override string ToString()
		{
			return ShowInfo();
		}

	


	}
}
