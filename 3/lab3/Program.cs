using System;
using System.IO;

namespace lab3
{
				class Program
				{
								static void Main(string[] args)
								{
												// Настраиваем ввод\вывод
												TextWriter outStream = Console.Out;
												TextReader readStream = Console.In;

												StreamWriter output = new StreamWriter(@"output.txt");
												StreamReader input = new StreamReader(@"input.txt");
												Console.SetOut(output);
												Console.SetIn(input);

												byte t = 0;
												try
												{
																t = Convert.ToByte(Console.ReadLine());
																int n = Convert.ToInt32(Console.ReadLine());
																double x = Convert.ToDouble(Console.ReadLine());
																double y = Convert.ToDouble(Console.ReadLine());

																Console.WriteLine(CalcSequence(x, y, n, t));
												}
												catch
												{
																Console.WriteLine("ERROR");
												}

												Console.SetOut(outStream);
												Console.SetIn(readStream);
												output.Close();
												input.Close();
								}

								static double CalcSequence(double x, double y, int n, byte type)
								{
												double result = 0;

												// Выбираем какой цикл использовать
												if(type == 0)
												{
																result = CalcSequanceUsingFor(n, x, y);
												}
												else if(type == 1)
												{
																result = CalcSequanceUsingWhile(n, x, y);
												}
												else
												{
																result = CalcSequanceUsingDoWhile(n, x, y);
												}
												return result;
								}

								private static double CalcSequanceUsingFor(int n, double x, double y)
								{
												double result = 0;
												for(int i = 2; i / 2 < n; i += 2)
												{
																bool isEven = (i / 2) > 2 && (i / 2) % 2 == 0;
																if(isEven)
																{
																				result -= Sequence(x, y, i);
																}
																else
																{
																				result += Sequence(x, y, i);
																}
												}
												return result;
								}

								private static double CalcSequanceUsingWhile(int n, double x, double y)
								{
												double result = 0;
												int i = 2;
												while(i / 2 < n)
												{
																bool isEven = (i / 2) > 2 && (i / 2) % 2 == 0;
																if(isEven)
																{
																				result -= Sequence(x, y, i);
																}
																else
																{
																				result += Sequence(x, y, i);
																}
																i += 2;
												}
												return result;
								}

								private static double CalcSequanceUsingDoWhile(int n, double x, double y)
								{
												double result = 0;
												int i = 2;
												do
												{
																bool isEven = (i / 2) > 2 && (i / 2) % 2 == 0;
																if(isEven)
																{
																				result -= Sequence(x, y, i);
																}
																else
																{
																				result += Sequence(x, y, i);
																}
																i += 2;
												} while(i / 2 < n);
												return result;
								}

								// Сразу опишем как вычисляется каждый член последовательности - (y^i * x^i-1) / i
								private static double Sequence(double x, double y, int i)
								{
												return (Math.Pow(y, i) * Math.Pow(x, i - 1)) / i;
								}
				}
}
