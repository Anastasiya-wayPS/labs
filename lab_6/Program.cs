using System;

namespace lab_6
{
				class Program
				{
								static void Main(string[] args)
								{
												Point point = new Point().Set();
												point.GetInfo();
												point.GetDistance(true);
								}
				}

				class Point
				{
								public float x = 0;
								public float y = 0;
								public float z = 0;

								public Point(float x = 0, float y = 0, float z = 0)
								{
												this.x = x;
												this.y = y;
												this.z = z;
								}

								public void GetInfo()
								{
												Console.WriteLine($"x: {x}; y: {y}; z: {z}");
								}

								public Point Set()
								{
												Console.WriteLine($"Введите x:");
												x = (float) Convert.ToDecimal(Console.ReadLine());
												Console.WriteLine($"Введите y:");
												y = (float) Convert.ToDecimal(Console.ReadLine());
												Console.WriteLine($"Введите z:");
												z = (float) Convert.ToDecimal(Console.ReadLine());

												return this;
								}

								public void GetDistance(bool ask = false)
								{
												float _x = 0, _y = 0, _z = 0;
												if(ask)
												{
																Console.WriteLine($"Введите x:");
																_x = (float) Convert.ToDecimal(Console.ReadLine());
																Console.WriteLine($"Введите y:");
																_y = (float) Convert.ToDecimal(Console.ReadLine());
																Console.WriteLine($"Введите z:");
																_z = (float) Convert.ToDecimal(Console.ReadLine());
												}
												Point target = new Point(_x, _y, _z);

												Console.WriteLine($"Расстояние до введенной точки x: {x - target.x}; y: {y - target.y}; z: {z - target.z}");
								}
				}
}
