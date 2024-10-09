﻿using System.Runtime.ExceptionServices;
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
        var caminhoNovoArquivo = "testaEscrita.txt";

        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDoArquivo))
        {
            escritor.Write("456,65465,456.0,Pedro");
        }
    }

    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";

        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDoArquivo))
        {
            for (int i = 0; i < 100000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush(); //Despeja o buffer para o Stream
                
                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle Enter...");
                Console.ReadLine();
            }
        }
    }
}