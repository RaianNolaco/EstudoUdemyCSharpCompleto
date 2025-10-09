using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComArquivos
{
    public static class UsingBlock
    {
        private static string soucepath = @"C:\Users\raian\Documents\file1.txt";

        public static void executar()
        {

            primeiraForma();
            segundaForma();
        }


        private static void primeiraForma()
        {
            try
            {
                using (FileStream fs = new FileStream(soucepath, FileMode.Open))
                {

                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Algo deu errado: ");
                Console.WriteLine(e.Message);
                throw;
            }
        }


        private static void segundaForma()
        {
            try
            {
                using (StreamReader sr = File.OpenText(soucepath))
                {                
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Algo deu errado: ");
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
