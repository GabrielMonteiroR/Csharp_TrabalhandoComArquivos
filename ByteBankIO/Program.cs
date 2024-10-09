partial class Program
{
    static void Main(string[] args)
    {
    
        var caminhoNovoArquivo = "testaescrita.txt";

        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDoArquivo))
        {
            escritor.WriteLine(true);
            escritor.WriteLine(false);
            escritor.WriteLine(4545454545);
        }

        System.Console.WriteLine("Aplicação finalizada.....");
        System.Console.ReadLine();
    }
    
}