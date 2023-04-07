// See https://aka.ms/new-console-template for more information

string opiniao;

Console.Write("Qual é a sua opinião sobre esse programa?");
opiniao = Console.ReadLine()!;
Console.WriteLine($"{opiniao.Remove(10)}...NÃO, PERA. \n Tô nervoso");

Console.ForegroundColor = ConsoleColor.Green;




