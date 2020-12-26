using System;

namespace lab_7
{
				class Program
				{
								static void Main(string[] args)
								{
												Cylinder cylinder = new Cylinder().Set();
												cylinder.GetInfo();
												cylinder.GetSquare();
								}
				}

				class Cylinder
				{
								public float h = 0;
								public float r = 0;

								public Cylinder(float h = 0, float r = 0)
								{
												this.h = h;
												this.r = r;
								}

								public void GetInfo()
								{
												Console.WriteLine($"h: {h}; r: {r};");
								}

								public Cylinder Set()
								{
												Console.WriteLine($"Введите h:");
												h = (float) Convert.ToDecimal(Console.ReadLine());
												Console.WriteLine($"Введите r:");
												r = (float) Convert.ToDecimal(Console.ReadLine());

												return this;
								}

								public void GetSquare()
								{
												double square = 2 * Math.PI * r * (h + r);
												Console.WriteLine($"Square: {square}");
								}
				}
}
