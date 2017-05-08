using Teste =  StreamWriterStreamReader.Application.Escrita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriterStreamReader.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste.ExemploStreamWriter.Gravar();

            
            Teste.ExemploStreamWriter.Leitura();

            Console.ReadKey();

        }
    }
}
