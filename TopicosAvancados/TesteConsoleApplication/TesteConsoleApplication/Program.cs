using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase. Pressione Ctrl+C para sair");
            TextReader leitor = Console.In;
            string linha = leitor.ReadLine();
            while (linha != null)
            {
                linha = leitor.ReadLine();
            }
        }
    }
}
