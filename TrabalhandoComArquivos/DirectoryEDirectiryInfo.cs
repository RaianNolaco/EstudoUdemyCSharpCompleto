using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComArquivos
{
    public static class DirectoryEDirectiryInfo
    {
        private static string soucepath = @"C:\Users\raian\source\repos\EstudoCursoUdemy\TrabalhandoComArquivos\temp\myfolder";
        public static void executar()
        {
            try
            {
                IEnumerable<string> folder = Directory.EnumerateDirectories(soucepath, "*.*", SearchOption.AllDirectories);

                foreach (var item in folder)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("-----------------------------------");

                IEnumerable<string> files = Directory.EnumerateFiles(soucepath, "*.*", SearchOption.AllDirectories);

                foreach (var item in files)
                {
                    Console.WriteLine(item);
                }

                Directory.CreateDirectory(soucepath + @"\newfolder");
            }
            catch (IOException ex) 
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
