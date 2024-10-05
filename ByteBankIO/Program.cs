using System.Text;


//1 PASSO: Definir o endereço do aruivo
var FileAddress = "C:\\Users\\gmont\\OneDrive\\Desktop\\Csharp_TrabalhandoComArquivos\\ByteBankIO\\contas.txt";
var bytesRead = -1; 

//2 PASSO: Criar um FileStream e passar qual operação será utilizada
//o fileStream le o arquivo parte por parte sem ler o mesmo inteiro
var fileStream = new FileStream(FileAddress, FileMode.Open);

//3: Criar um buffer para armazenar os bytes lidos do arquivo
var buffer = new byte[1024];

//4: Enquanto o arquivo não terminar de ser lido
while (bytesRead != 0)
{
    //5: Passar o buffer para o FileStream e ler o arquivo onde ele vai ler a partir da posição 0 até 1024 bytes lendo item por item
     bytesRead = fileStream.Read(buffer, 0, 1024);
     WriteBuffer(buffer);

}

//Fechar o fluxo do arquivo
fileStream.Close();

//6: Criar um método para escrever o buffer, onde ele vai converter os bytes em string
static void WriteBuffer(byte[] buffer)
{
    var utf8 = new UTF8Encoding();
    var text = utf8.GetString(buffer);
    Console.WriteLine(text);

}

