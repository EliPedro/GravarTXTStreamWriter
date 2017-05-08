using System;
using System.IO;
using System.Text;

namespace StreamWriterStreamReader.Application.Escrita
{
    public class ExemploStreamWriter
    {
        private static string FilePath;

        public static void Gravar()
        {
            //Definir as variáveis para o exemplo
            string nome = "Mirosmar";
            string endereco = "Alameda Jaú, 32";
            string cidade = "São Paulo";
            string uf = "SP";
            string texto = "banco";
            string plural = texto.Pluralize();

            if(ExemploStreamWriter.FilePath == null)
            {
                FilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                #region Directory
                //if(!Directory.Exists(FilePath))
                //{
                //    Directory.CreateDirectory(FilePath);
                //}
                #endregion
            }

            var path = Path.Combine(FilePath, "Exemplo.txt");

            //Definir o objeto StreamWriter
            using (StreamWriter stw = new StreamWriter(path, true))
            {

                //Escrever no arquivo de texto
                //valor com tamanho fixo, exemplo,
                //nome com 20 posições, endereço com 25 ...

                stw.WriteLine(nome.PadRight(20) + //20 Espaços
                              endereco.PadRight(25) +
                              cidade.PadRight(20) +
                              plural.PadRight(20) +
                              uf);
 
            }
        }

        public  static void Leitura()
        {
            string registro = string.Empty;
            
            if(ExemploStreamWriter.FilePath != null)
            {
                if(Directory.Exists(FilePath))
                {
                    var path = Path.Combine(FilePath + @"\Exemplo.txt");

                    if(File.Exists(path))
                    {
                        StreamReader str = new StreamReader(path, Encoding.UTF8);
                        
                        Console.WriteLine(str.ReadToEnd());

                    }

                    #region EndOfStream
                    //while(!str.EndOfStream)
                    //{
                    //    registro = str.ReadLine();
                    //    //Recuperar o nome a partir das 20 primeiras posições
                    //    //e depois remover os espaços em branco existentes
                    //    Console.WriteLine("Nome: " + registro.Substring(0, 20).Trim());

                    //    Console.WriteLine("Endereço: " + registro.Substring(20, 25).Trim());

                    //    Console.WriteLine("Cidade: " + registro.Substring(45,20 ).Trim());

                    //    Console.WriteLine("UF: " + registro.Substring(65,2).Trim());


                    //}
                    #endregion
                }
            }
            
        }

    }
}
