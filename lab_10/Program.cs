using System;
using lab_10_Core;

namespace lab_10
{
				class Program
				{
								static void Main(string[] args)
								{
												string matrix1Name = "matrix1.txt";
												string matrix2Name = "matrix2.txt";

												Matrix matrix1 = new Matrix();
												matrix1.Generate(4, 4);
												matrix1.SaveInFile(matrix1Name);
												if(matrix1.LoadMatrixFromFile(matrix1Name))
																matrix1.PrintMatrix();

												Matrix matrix2 = new Matrix();
												matrix2.Generate(4, 4);
												matrix2.SaveInFile(matrix2Name);
												if(matrix2.LoadMatrixFromFile(matrix2Name))
																matrix2.PrintMatrix();

												float sum = 0;
												for(int i = 0; i < 4; i++)
												{
																sum += matrix1.self[i, i] + matrix2.self[i, i];
												}
												Console.WriteLine($"Sum of matrix elements: {sum}");
								}
				}
}
