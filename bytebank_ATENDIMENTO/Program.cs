Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//TestaArrayInt();
//TestaBuscarPalavra();
void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 15;
    idades[1] = 28;
    idades[2] = 35;
    idades[3] = 50;
    idades[4] = 42;

    Console.WriteLine($"Tamanho do array: {idades.Length}");
    int acumulador = 0;
    for(int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Idade no índice {i}: {idade}");
        acumulador += idade;
    }
    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idades: {media}");
}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for(int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i+ 1}ª palavra:");
        arrayDePalavras[i] = Console.ReadLine();
    }
    Console.Write("Digite a palavra que deseja buscar: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if(palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }
    }
}

Array amostra = Array.CreateInstance(typeof(double), 5); //arrays criados, herdam caracteristicas dessa classe
amostra.SetValue(5.9,0);
amostra.SetValue(1.8,1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

TestaMediana(amostra);
void TestaMediana(Array array)
{
    if((array == null ) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana é nulo ou vazio");
    }
    double[] numerosOrdenados = (double[])array.Clone(); //Clone tem tipo Object, logo tem que converter
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : numerosOrdenados[meio] + numerosOrdenados[meio - 1] / 2;
    Console.WriteLine($"Mediana: {mediana}");
}
int[] valores = { 10, 58, 36, 47 };
for (int i = 0; i < valores.Length; i++)
{
    Console.WriteLine($"Índice {i}, valor: {valores[i]}");
}
