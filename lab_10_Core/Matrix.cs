using System;
using System.IO;

namespace lab_10_Core
{
				public class Matrix
				{
								public float[,] self;
								int rows, cols;

								public Matrix()
								{
								
								}

								public void Generate(int rows, int cols)
								{
												this.rows = rows;
												this.cols = cols;

												Random randomizer = new Random(DateTime.Now.Millisecond);

												self = new float[rows, cols];
												for(int row = 0; row < rows; row++)
												{
																for(int col = 0; col < cols; col++)
																{
																				self[row, col] = randomizer.Next() / 973F;
																}
												}
								}

								public void SaveInFile(string fileName)
								{
												if(self.Length == 0)
																return;

												if(File.Exists(fileName))
																File.Delete(fileName);

												FileInfo fileInfo = new FileInfo(fileName);
												TextWriter writer = fileInfo.CreateText();

												writer.WriteLine(rows.ToString());
												writer.WriteLine(cols.ToString());

												for(int row = 0; row < rows; row++)
												{
																for(int col = 0; col < cols; col++)
																{
																				Console.WriteLine($"{row} {col} {self[row, col].ToString("E10")}");
																}
												}
								}

								public bool LoadMatrixFromFile(string fileName)
								{
												if(!File.Exists(fileName))
																return false;

												try
												{
																TextReader reader = File.OpenText(fileName);
																rows = Convert.ToInt32(reader.ReadLine());
																cols = Convert.ToInt32(reader.ReadLine());

																self = new float[rows, cols];
																string line;
																string[] parsedLine;

																for(int row = 0; row < rows; row++)
																{
																				for(int col = 0; col < cols; col++)
																				{
																								line = reader.ReadLine();
																								parsedLine = line.Split(' ', 3);
																								self[row, col] = Convert.ToSingle(parsedLine[2]);
																				}
																}

																return true;
												}
												catch(Exception ex)
												{
																Console.WriteLine(ex.Message);
																return false;
												}
								}

								public void PrintMatrix()
								{
												if(self.Length == 0)
																return;

												for(int row = 0; row < rows; row++)
												{
																for(int col = 0; col < cols; col++)
																{
																				Console.Write(self[row, col].ToString("E3") + " ");
																}
																Console.WriteLine();
												}
								}
				}
}
