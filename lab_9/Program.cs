using System;

namespace lab_9
{
				class Program
				{
								static void Main(string[] args)
								{
												Human human = new Human("Громова Анастасия", 18);
												human.Plus(1);
												human.Minus(1);
												human.DrawObject();

												Car car = new Car("Tesla", "Model S", 200);
												car.Plus(50);
												car.Minus(10);
												car.DrawObject();
								}
				}

				public interface ICalcalutable
				{
								void Plus(int plus);
								void Minus(int minus);
				}

				public interface IVisualizable
				{
								string Name
								{
												get; set;
								}
								void DrawObject();
				}

				public class Human: ICalcalutable, IVisualizable
				{
								private string FullName;
								private int Age;

								public Human(string fullName, int age)
								{
												FullName = fullName;
												Age = age;
								}

								public string Name
								{
												get => $"{FullName}: {Age}";
												set => FullName = value;
								}

								public void DrawObject()
								{
												Console.WriteLine(
																" ( )\n" +
																"/ | \\ \n" +
																"  | \n" +
																" / \\ \n"
												);
								}

								public void Minus(int minus)
								{
												Age -= minus;
								}

								public void Plus(int plus)
								{
												Age += plus;
								}
				}

				public class Car: ICalcalutable, IVisualizable
				{
								private string Manufacturer;
								private string Model;
								private int Velocity;

								public Car(string manufacturer, string model, int velocity)
								{
												Manufacturer = manufacturer;
												Model = model;
												Velocity = velocity;
								}

								public string Name
								{
												get => $"{Manufacturer} - {Model}: {Velocity} km/h";
												set => Model = value;
								}

								public void DrawObject()
								{
												Console.WriteLine(
															"    ___________\n" +
															"___/____|____|__\\___\n" +
															"|       |    |  |    |\n" +
															"--(@)------(@)------- \n"
											);
								}

								public void Minus(int minus)
								{
												Velocity -= minus;
								}

								public void Plus(int plus)
								{
												Velocity += plus;
								}
				}
}
