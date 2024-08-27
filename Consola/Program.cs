// See https://aka.ms/new-console-template for more information
Console.WriteLine("Web Scrapping");
string buscar = Console.ReadLine();

string res = WebScrapping.ScappingHandler.Search(buscar);

Console.WriteLine(res);
Console.ReadKey();
