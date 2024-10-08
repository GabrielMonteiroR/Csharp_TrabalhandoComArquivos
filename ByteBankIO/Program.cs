namespace ByteBankIO
{

    partial class Program
    {
        static void Main(string[] args)
        {
            var enderecoDoArquivo = "contas.txt";
            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var leitor = new StreamReader(fluxoDeArquivo);


                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var contaCorrente = ConverterStringParaContaCorrente(linha);

                    var msg = $"Conta Corrente: {contaCorrente.Numero}" +
                        $"\nAgência: {contaCorrente.Agencia}" +
                        $"\nSaldo: {contaCorrente.Saldo}\n\n" +
                        $"\nTitular: {contaCorrente.Titular.Nome}";

                    Console.WriteLine(msg);

                }
            }
        }
        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            // 375 4644 2483.13 Jonatan
            var campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.',',');
            var nomeTitular = campos[3];

            var agenciaComInt = int.Parse(agencia);
            var numeroComInt = int.Parse(numero);
            var saldoComoDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
            resultado.Depositar(saldoComoDouble);
            resultado.Titular = titular;

            return resultado;
        }
    }
}