using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace lab_4
{
				class Program
				{
								static void Main(string[] args)
								{
												TextWriter outStream = Console.Out;
												TextReader readStream = Console.In;

												StreamWriter output = new StreamWriter(@"output.txt");
												StreamReader input = new StreamReader(@"input.txt");
												Console.SetOut(output);
												Console.SetIn(input);

												try
												{
																int[] numbers = ReadInput();
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

								static int[] ReadInput()
								{
												try
												{
																int inputLength = Convert.ToInt32(Console.ReadLine());
																String[] tmpInput = Console.ReadLine().Split(' ');

																int[] numbers = new int[inputLength];
																int sum = 0;
																int max = 0;
																int min = 0;
																for(int i = 0; i < inputLength; i++)
																{
																				numbers[i] = Convert.ToInt32(tmpInput[i]);
																				if(numbers[i] > max)
																				{
																								max = numbers[i];
																				}

																				if(numbers[i] < min)
																				{
																								min = numbers[i];
																				}
																				sum += numbers[i];
																}

																Console.WriteLine((min + max) / 2);
																Console.WriteLine(sum / inputLength);
																Console.WriteLine(FindAllThatGreater(numbers, sum / inputLength));

																return numbers;
												}
												catch(Exception ex)
												{
																throw ex;
												}

								}

								static int[] FindAllThatGreater(int[] numbers, int toCompare)
								{
												int[] founded = new int[numbers.Length];
												for(int i = 0; i < numbers.Length; i++)
												{
																if(numbers[i] < toCompare)
																{
																				founded[i] = numbers[i];
																}
												}

												return founded;
								}
				}
}
