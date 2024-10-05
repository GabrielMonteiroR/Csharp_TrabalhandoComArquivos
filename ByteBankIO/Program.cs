partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "C:\\Users\\gmont\\OneDrive\\Desktop\\Csharp_TrabalhandoComArquivos\\ByteBankIO\\contas.txt";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            //pega a primeira linha do arquivo
            var linha  = leitor.ReadLine();
            System.Console.WriteLine(linha);
        }


        Console.WriteLine();
    }
}