using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrabalhandoComArquivos
{
    public static class PathAula
    {
        private static string soucepath = @"C:\Users\raian\source\repos\EstudoCursoUdemy\TrabalhandoComArquivos\temp\myfolder\file1.txt";
        public static void executar()
        {
            try
            {
                Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(soucepath));
                Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
                Console.WriteLine("GetFileName: " + Path.GetFileName(soucepath));
                Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(soucepath));
                Console.WriteLine("GetExtension: " + Path.GetExtension(soucepath));
                Console.WriteLine("GetFullPath: " + Path.GetFullPath(soucepath));
                Console.WriteLine("GetTempPath: " + Path.GetTempPath());
                
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
