using Core.Data;
using Core.Models;
using System.ComponentModel.Design;

namespace Planets
{
	internal class Program
	{
	



		static void Main(string[] args)
		{
			bool f = false;
			bool f1 = false;
			bool f3 = false;
			bool TrueValue = true;
			int planetid;
			double area;

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("-----------------------------------------Menu------------------------------------");



			do
			{
				Console.WriteLine("1-Sisteme giris\r\n0-Cixis");
				Console.WriteLine("::Seciminizi daxil edin: ");
				string option = Console.ReadLine();
				
				switch (option)
				{
					case "1":
						Console.WriteLine("---Sisteme girildi.");
						Console.WriteLine("1.planet yarat\r\n2.Butun Planetleri gor\r\n3.Planet sec (planetin adini daxil ederek secilecek)\r\n0.Exit");


						do
						{

							Console.WriteLine("::Seciminizi daxil edin: ");
							string option2 = Console.ReadLine();
							switch (option2)
							{
								case "1":
									Console.WriteLine("Planet yareatmaq ucun Asagida teleb olunan melubatlari doldurun. ");
									//int PlanetId,string name, double area
									
									do
									{
										Console.WriteLine("Planet ucun id: ");
										TrueValue = int.TryParse(Console.ReadLine(), out planetid);
										{
											if (!TrueValue)
											{
												Console.WriteLine("ID daxil ederken yazi xetasi oldu,Reqemden basqa sinvol istifade etmeyin.");
											}
										}
									} while (!TrueValue);
									
									Console.WriteLine("Name: ");
									string name = Console.ReadLine();
									do
									{
										Console.WriteLine("Area daxil edin");
										TrueValue = double.TryParse(Console.ReadLine(), out area);
										{
											if (!TrueValue)
											{
												Console.WriteLine("Area daxil ederken yazi xetasi oldu,Reqemden basqa sinvol istifade etmeyin.");
											}
										}

									} while (!TrueValue);
									
									Planet planet = new Planet(planetid, name, area);
									AppDbContext.CreatePlanet(planet);
									Console.WriteLine("Planet yaradildi.");

									break;
								case "2":
									//2.Butun Planetleri gorgor
									AppDbContext.GetAllPlanets();
									break;
								case "3":
									Console.WriteLine("Planet adi daxil edin.");

									string NAME = Console.ReadLine();
									if (AppDbContext.GetPlanet(NAME) == true)
									{
										Console.WriteLine("Daxil etdiyiniz adda planet secildi.");
										do
										{
											Console.WriteLine("1.olke yarat\r\n2.olke gor\r\n3.Evvelki menuya qayit.\r\n0.Exit");
											Console.WriteLine("Seciminizi daxil edin.");

											string option3 = Console.ReadLine();
											switch (option3)
											{
												case "1":
													///string countryName, double area, string anthem, string region
													Console.WriteLine("Asagida teleb edilen infolari verinki country yarada bilek");
													Console.WriteLine("Name: ");
													string countryName = Console.ReadLine();
													Console.WriteLine("Area: ");
													do
													{
														Console.WriteLine("Area daxil edin");
														TrueValue = double.TryParse(Console.ReadLine(), out area);
														{
															if (!TrueValue)
															{
																Console.WriteLine("Area daxil ederken yazi xetasi oldu,Reqemden basqa sinvol istifade etmeyin.");
															}
														}

													} while (!TrueValue);
													Console.WriteLine("anthem");
													string anthem = Console.ReadLine();
													Console.WriteLine("region");
													string region = Console.ReadLine();
													Country country = new Country(countryName, area, anthem, region);
													AppDbContext.CreateCountry(country);
													Console.WriteLine("Countery yaradildi.");

													break;
												case "2":
													AppDbContext.GetAllCountries();

													break;
												case "3":
													f3 = true;
													break;
												case "0":
													Console.WriteLine("sistemden cixildi");
													f3 = true;
													f1 = true;
													f = true;

													break;
												default:
													Console.WriteLine("Invalid option");
													break;
											}
										} while (!f3);
									}

									break;
								case "0":
									Console.WriteLine("Geriye qayidildi...");
									f1 = true;
									break;


								default:
									Console.WriteLine("Invalid option.");
									break;
							}

						} while (!f1);
						break;


					case "0":
						Console.WriteLine("Sistemden cixildi.");
						f = true;
						break;

					default:
						Console.WriteLine("Invalid Option");
						break;
				}

			} while (!f);
		}
	}
}
