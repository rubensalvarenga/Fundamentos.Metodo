using System;

namespace Fundamentos.Metodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeuMetodo();
            Console.BackgroundColor = ConsoleColor.Red;   
            string nome = RetornaNome("Rubens", "Alvarenga", 51);
            Console.WriteLine(nome);
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static void MeuMetodo()
        {
            Console.WriteLine("C# é legal !!!");

            

            Console.WriteLine("");
            Console.WriteLine("");
        }

        static string RetornaNome ( string primeiro , string segundo, int idade = 21)
        {
            return (primeiro + " " + segundo+", idade : "+idade.ToString()+" anos");
        }
    }
}
