using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComArquivos
{
    public static class FileFileInfoIOException
    {
        public static void executar()
        {
            string soucepath = @"C:\Users\raian\Documents\file1.txt";
            string targetFile = $@"C:\Users\raian\Documents\file{DateTime.Now.Millisecond}.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(soucepath);
                fileInfo.CopyTo(targetFile);

                Console.WriteLine(fileInfo.LastAccessTime);

                string[] linhas = File.ReadAllLines(soucepath);

                foreach (string line in linhas)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
