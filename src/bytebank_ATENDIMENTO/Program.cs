Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

//TesteArrayInt();
//TesteBuscaPalavra();

void TesteArrayInt()
{
    Random rnd = new Random();
    int[] idades = new int[5];

    for (int i = 0; i < 5; i++)
        idades[i] = rnd.Next(18, 90);

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    for (int i = 0; i < idades.Length; i++)
        Console.WriteLine($"indice [{i}] = {idades[i]}");

    Console.WriteLine($"Valor total do Array {idades.Sum()}");
    Console.WriteLine($"Valor da Media de idades {Convert.ToInt32(idades.Average())}");
}

void TesteBuscaPalavra()
{
    string[] palavras = { "Banana", "Limão", "Maça", "Pera", "Uva" };

    Console.WriteLine("Digite palavra a ser buscada: ");
    var busca = Console.ReadLine();

    if (palavras.Contains(busca))
        Console.WriteLine($"Palavra encontrada = {busca}");
    else
        Console.WriteLine($"Palavra {busca} não foi encontrada ");
};

Array amostar = Array.CreateInstance(typeof(double), 5);
amostar.SetValue(5.9, 0);
amostar.SetValue(1.8, 1);
amostar.SetValue(7.1, 2);
amostar.SetValue(10, 3);
amostar.SetValue(6.9, 4);

TestaMediana(amostar);

void TestaMediana(Array array)
{
    if ((array == null) || array.Length == 0)
        Console.WriteLine("Array para calculo da mediana está vazio ou nulo");
    else
    {
        double[] numerosOrdenados = (double[])array.Clone();
        Array.Sort(numerosOrdenados);
        int tamanho = numerosOrdenados.Length;
        int meio = tamanho / 2;
        double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
            (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
        Console.WriteLine($"Com base na amostra a mediana = {mediana}");
    }
};

int[] valores = { 10, 58, 36, 47 };
for (int i = 0; i < valores.Length; i++)
{
    Console.WriteLine(valores[i]);
};
