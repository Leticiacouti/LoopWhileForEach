using System;
using System.Collections.Generic;

namespace LoopWhileForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomes = LoopWhileFor();
            LoopWhileForEach(nomes);
        }


        public static List<string> LoopWhileFor()
        {
            string nome = string.Empty;
            List<string> nomes = new List<string>();

            while (nome == "fim")
            {
                Console.WriteLine("Informe um nome");
                nome = Console.ReadLine();

                if (nome != "fim")
                    nomes.Add(nome);
            }

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {nomes[i]}");
            }

            return nomes;
        }

        public static void LoopWhileForEach(List<string> nomes)
        {
            Console.WriteLine("Agora é o foreach");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            nomes.ForEach(x => Console.WriteLine(x));
        }
    }
}
