partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "C:\\Users\\gmont\\OneDrive\\Desktop\\Csharp_TrabalhandoComArquivos\\ByteBankIO\\contas.txt";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            // var linha = leitor.ReadLine();  le a primeira linha
            // var text = leitor.ReadToEnd(); le o arquivo todo (de uma vez sem ser parte por parte)
            // var numero = leitor.Read(); le o primeiro byte

            //Enquanto o fluxo não chegar ao fim
            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                System.Console.WriteLine(linha);
            }


            Console.WriteLine();
        }
    }
}