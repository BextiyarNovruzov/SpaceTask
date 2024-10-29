using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
	public class Planet
	{

		//PlanetId
		//Name
		//Area
		
		public int PlanetId { get; set; }
		public string Name { get; set; }
		public double Area { get; set; }
		public Planet(int planetid, string name, double area)
		{
			PlanetId = planetid;
			Name = name;
			Area = area;
		}

		public string ShowInfo()
		{
			return $" Name: {Name}";
		}
		public override string ToString()
		{
			return ShowInfo();
		}

	}
}
