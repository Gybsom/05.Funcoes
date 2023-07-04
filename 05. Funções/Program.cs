internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe um número inteiro:");
        int numero = Convert.ToInt32(Console.ReadLine());
        int numeroTriplicado = TriplicaNumero(numero);
        Console.WriteLine("O triplo do número " + numero + " é " + numeroTriplicado);
        Console.WriteLine(numero);
    }

    static int TriplicaNumero (int numero)
    {
        numero = numero * 3;
        
        return numero;
    }
}