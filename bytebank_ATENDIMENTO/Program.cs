using bytebank_ATENDIMENTO.bytebank.Atendimento;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
#region EXEMPLOS ARRAY
/*//TestaArrayInt();
//TestaBuscarPalavra();
TestaArrayDeContas();
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

//TestaMediana(amostra);
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

void TestaArrayDeContas()
{
    ListasContaCorrente listaDeContas = new ListasContaCorrente();
    listaDeContas.AdicionarConta(new ContaCorrente(123, "456789-0"));
    listaDeContas.AdicionarConta(new ContaCorrente(321, "987654-0"));
    listaDeContas.AdicionarConta(new ContaCorrente(213, "654321-0"));
    listaDeContas.AdicionarConta(new ContaCorrente(132, "123456-0"));
    listaDeContas.AdicionarConta(new ContaCorrente(231, "789123-0"));
    listaDeContas.AdicionarConta(new ContaCorrente(312, "321987-0"));
    var conta = new ContaCorrente(111, "000111-0");
    //listaDeContas.AdicionarConta(conta);
    //listaDeContas.ExibirLista();
    //listaDeContas.RemoverConta(conta);
    //listaDeContas.ExibirLista();
    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente novaConta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}] - {novaConta.Conta}");
    }

}*/
#endregion 
#region EXEMPLOS LISTA
//List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
//{
//    new ContaCorrente(123, "456789-0"){Saldo = 100},
//    new ContaCorrente(321, "987654-0"){Saldo = 200},
//    new ContaCorrente(213, "654321-0"){Saldo = 300},
//};
//List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
//{
//    new ContaCorrente(123, "456789-0"){Saldo = 100},
//    new ContaCorrente(321, "987654-0"){Saldo = 200},
//    new ContaCorrente(213, "654321-0"){Saldo = 300},
//};
//List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
//{
//    new ContaCorrente(123, "456789-0"){Saldo = 100},
//    new ContaCorrente(321, "987654-0"){Saldo = 200},
//    new ContaCorrente(213, "654321-0"){Saldo = 300},
//};
//_listaDeContas2.AddRange(_listaDeContas3);
//_listaDeContas2.Reverse();
//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    ContaCorrente conta = _listaDeContas2[i];
//    Console.WriteLine($"Índice [{i}] - Conta {conta.Conta}, Agência: {conta.Numero_agencia}, Saldo: {conta.Saldo}");
//}

//Console.WriteLine("\n");

//var range = _listaDeContas3.GetRange(0, 1);
//for(int i = 0; i < range.Count; i++)
//{
//    ContaCorrente conta = range[i];
//    Console.WriteLine($"Índice [{i}] - Conta {conta.Conta}, Agência: {conta.Numero_agencia}, Saldo: {conta.Saldo}");
//}

//Console.WriteLine("\n");

//_listaDeContas3.Clear();
//for (int i = 0; i < range.Count; i++)
//{
//    ContaCorrente conta = range[i];
//    Console.WriteLine($"Índice [{i}] - Conta {conta.Conta}, Agência: {conta.Numero_agencia}, Saldo: {conta.Saldo}");
//}
#endregion

new ByteBankAtendimento().AtendimentoCliente();