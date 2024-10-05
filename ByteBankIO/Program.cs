using System.Text;

// 1º PASSO: Definir o caminho do arquivo que será lido
var FileAddress = "C:\\Users\\gmont\\OneDrive\\Desktop\\Csharp_TrabalhandoComArquivos\\ByteBankIO\\contas.txt";

// O bloco using garante que o objeto FileStream seja corretamente descartado (fechado) ao final do uso,
// mesmo que ocorra uma exceção, liberando os recursos do sistema.
using (var fileStream = new FileStream(FileAddress, FileMode.Open))
{
    var bytesRead = -1;  // Variável para armazenar a quantidade de bytes lidos em cada iteração

    // 2º PASSO: O FileStream abre o arquivo para leitura e lê o arquivo em partes (chunks),
    // em vez de carregar o arquivo inteiro na memória, o que é útil para grandes arquivos.

    // 3º PASSO: Criar um buffer (array de bytes) para armazenar temporariamente os dados lidos do arquivo.
    // O tamanho do buffer neste caso é 1024 bytes (1 KB).
    var buffer = new byte[1024];

    // 4º PASSO: O loop continua até que bytesRead seja 0, o que indica que o final do arquivo foi alcançado.
    while (bytesRead != 0)
    {
        // 5º PASSO: Ler o próximo bloco de bytes do arquivo e armazená-lo no buffer.
        // O método Read tenta ler até 1024 bytes, começando da posição 0 do buffer.
        // O valor retornado é o número real de bytes lidos (pode ser menor que 1024, especialmente na última leitura).
        bytesRead = fileStream.Read(buffer, 0, 1024);
        
        // Se bytes foram lidos, processar e escrever no console.
        if (bytesRead > 0)
        {
            WriteBuffer(buffer, bytesRead);
        }
    }

    // O FileStream será fechado automaticamente pelo bloco using, não é necessário chamar Close manualmente.
}

// 6º PASSO: Método responsável por converter os bytes lidos em string (usando codificação UTF-8)
// e exibir o conteúdo no console. Ele interpreta os dados lidos como texto.
static void WriteBuffer(byte[] buffer, int readBytes)
{
    var utf8 = new UTF8Encoding();     // Definindo a codificação como UTF-8
    var text = utf8.GetString(buffer, 0, readBytes); // Converte os bytes em string usando a codificação UTF-8
    Console.WriteLine(text);           // Exibe o texto convertido no console
}
