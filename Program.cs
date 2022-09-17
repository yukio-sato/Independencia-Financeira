
Console.ForegroundColor = ConsoleColor.Red;
for (int i = 0; i < 24; i++)
{
    Console.Write("Gastos mensais (em R$): "[i]);
    Thread.Sleep(65);
}
decimal gastomensais = Convert.ToDecimal(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Yellow;
for (int i = 0; i < 25; i++)
{
    Console.Write("Rendimentos mensais (%): "[i]);
    Thread.Sleep(65);
}
decimal rendimentomensais = Convert.ToDecimal(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nPara receber R$ {gastomensais:N2} por mês com rendimentos de {rendimentomensais:N1}% você precisa ter investido R$ {(gastomensais/(rendimentomensais/100)):N2}.");
Console.ResetColor();