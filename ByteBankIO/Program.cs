using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {

        //1: Localizar o arquivo
        var enderecoDoArquivo = "C:\\Users\\gmont\\OneDrive\\Desktop\\Csharp_TrabalhandoComArquivos\\ByteBankIO\\contas.txt";

        //2: Criar um fluxo de bytes para ler o arquivo
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);
        //                                  local                   método que será utilizado

        //3: Recuperar os bytes do arquivo
        var buffer = new byte[1024];

        //4: 1.parametro:Array de Bytes que já foram lidos
        //2.parametro: local de inicio
        //3.parametro: quantas posições serão preenchidas
        fluxoDoArquivo.Read(buffer);


    }
}