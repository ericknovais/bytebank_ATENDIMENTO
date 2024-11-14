Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

//TesteArrayInt();
TesteBuscaPalavra();

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