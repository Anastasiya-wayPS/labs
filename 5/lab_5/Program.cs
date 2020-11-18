using System;
using System.IO;

namespace lab_5
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
																int rows = Convert.ToInt32(Console.ReadLine());
																int cols = Convert.ToInt32(Console.ReadLine());

																int[,] matrix = new int[rows, cols];
																for(int i = 0; i < rows; i++)
																{
																				int[] row = ReadRow(cols);
																				for(int j = 0; j < row.Length; j++)
																				{
																								matrix[i, j] = row[i];
																				}
																}

																for(int i = 0; i < rows; i++)
																{
																				for(int j = 0; j < cols; j++)
																				{
																								Console.Write(matrix[i, j]);
																								Console.Write(' ');
																				}
																				Console.WriteLine();
																}

																int[,] modifiedMatrix = new int[rows, cols];
																int[] averages = new int[cols];
																for(int i = 0; i < cols; i++)
																{
																				int average = 0;
																				for(int j = 0; j < rows; j++)
																				{
																								average += matrix[j, i];
																				}
																				Console.WriteLine(average / rows);
																				averages[i] = average / rows;
																}

																for(int i = 0; i < rows; i++)
																{
																				for(int j = 0; j < cols; j++)
																				{
																								int el = matrix[i, j];

																								if(el < averages[j])
																								{
																												Console.Write(i);
																								}
																								else
																								{
																												Console.Write(j);
																								}

																								Console.Write(' ');
																				}

																				Console.WriteLine();
																}

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

								static int[] ReadRow(int length)
								{
												try
												{
																String[] tmpInput = Console.ReadLine().Split(' ');

																int[] numbers = new int[length];
																for(int i = 0; i < length; i++)
																{
																				numbers[i] = Convert.ToInt32(tmpInput[i]);
																}

																return numbers;
												}
												catch(Exception ex)
												{
																throw ex;
												}
								}
				}
}
