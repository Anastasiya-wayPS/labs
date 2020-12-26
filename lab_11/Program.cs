using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lab_11
{
				class Program
				{
								const string INPUT_FILE = "lr11_04.csv";

								static void Main(string[] args)
								{
												StreamReader reader = new StreamReader(INPUT_FILE);
#if !DEBUG
																TextWriter output = Console.Out;
																StreamWriter newOutput = new StreamWriter(@"lr11_output.txt");
																Console.SetOut(newOutput);
#endif

												List<Employee> employees = new List<Employee>();
												String record = reader.ReadLine();

												List<String> companies = new List<string>();
												int canInEnglish = 0;
												const String eng = "English";
												int moreThan3K = 0;
												Dictionary<string, float> averageSalaryByCompanies = new Dictionary<string, float>();
												Dictionary<string, int> employeesCount = new Dictionary<string, int>();

												while((record = reader.ReadLine()) != null)
												{
																Console.WriteLine(record);
																Employee employee = new Employee(record);
																employees.Add(employee);
																if(!companies.Contains(employee.Company))
																				companies.Add(employee.Company);
																if(employee.Language == eng)
																				canInEnglish++;
																if(employee.GetSalary() > 3000F)
																				moreThan3K++;
																if(!averageSalaryByCompanies.ContainsKey(employee.Company))
																{
																				averageSalaryByCompanies.Add(employee.Company, employee.GetSalary());
																				employeesCount.Add(employee.Company, 1);
																}
																else
																{
																				averageSalaryByCompanies[employee.Company] += employee.GetSalary();
																				employeesCount[employee.Company]++;
																}

																foreach(string company in averageSalaryByCompanies.Keys)
																{
																				averageSalaryByCompanies[company] /= employeesCount[company];
																				Console.WriteLine($"Average salary in {company}: ${averageSalaryByCompanies[company]}");
																				Console.WriteLine($"Employees count in {company}: {employeesCount[company]}");
																}
																
																Console.WriteLine($"Knows English: {canInEnglish}");
																Console.WriteLine($"Salary is more than $3000: {moreThan3K}");
																
												}
												


				
#if !DEBUG
																Console.SetOut(output);
																newOutput.Close();
#endif
								}
				}

				class Employee
				{
								public string Id;
								public string FName;
								public string LName;
								public string Company;
								public string Salary
								{
												get => Salary;
												set => Salary = value.ToString().Substring(1);
								}
								public string Language;


								const char SEPARATOR = ',';
								public Employee(string source)
								{
												string[] parsed = source.Split(SEPARATOR);
												Id = parsed[0].Trim();
												FName = parsed[1].Trim();
												LName = parsed[2].Trim();
												Company = parsed[3].Trim();
												Salary = parsed[4].Trim();
												Language = parsed[5].Trim();
								}

								public float GetSalary() => Convert.ToSingle(Salary);
				}
}
