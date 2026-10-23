int coluna = 1; 
int linha = 1;     

while(linha <=5)
{
    while(coluna<5)
{
    Console.Write("* ");
    coluna = coluna + 1;
}
Console.WriteLine();

linha = linha + 1;
coluna = 1;
}