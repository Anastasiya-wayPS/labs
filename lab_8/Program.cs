using System;

namespace lab_8
{
				class Program
				{
								static void Main(string[] args)
								{
												Edition[] editions = [new Book("Some book", 100), new Magazine("Some magazine", 20), new Online("Some online magazine", 1, "https://google.com")];
												Console.WriteLine("Hello World!");
								}
				}

				enum EditionTypes
				{
								Book,
								Magazine,
								Online
				}

				class Edition
				{
								public string name;
								public int pagesCount = 0;
								EditionTypes type;

								public Edition(string name, int pagesCount)
								{
												this.name = name;
												this.pagesCount = pagesCount;
								}

								public void SetType(EditionTypes type)
								{
												this.type = type;
								}

								public virtual void PrintInfo()
								{
												Console.WriteLine($"{type.ToString()} - {name}. {pagesCount} страниц(-a). ");
								}
				}

				class Book : Edition
				{
								public Book(string name, int pagesCount) : base(name, pagesCount)
								{
												SetType(EditionTypes.Book);
								}
				}

				class Magazine : Edition
				{
								public Magazine(string name, int pagesCount) : base(name, pagesCount)
								{
												SetType(EditionTypes.Magazine);
								}
				}

				class Online : Edition
				{
								string link;
								public Online(string name, int pagesCount, string link) : base(name, pagesCount)
								{
												SetType(EditionTypes.Online);
												this.link = link;
								}

								public override void PrintInfo()
								{
												Console.WriteLine($"{name}. {link}");
								}
				}
}
