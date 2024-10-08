using System.Text;

partial class Program
{

    //OPÇÃO 1
    static void CriarArquivo()
    {
        //Local onde será guardado o novo arquivo
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456,78945,4785.40,Gustavo Santos";
            var encoding = Encoding.UTF8;
            var bytes = encoding.GetBytes(contaComoString);

            fluxoDoArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    //OPÇÃO 2
    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDoArquivo))
        {
            escritor.Write("456,65465,456.0,Pedro");
        }
    }
}