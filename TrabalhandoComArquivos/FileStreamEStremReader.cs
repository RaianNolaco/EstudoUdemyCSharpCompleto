using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComArquivos
{
    public static class FileStreamEStremReader
    {
        public static void executar()
        {
            string soucepath = @"C:\Users\raian\Documents\file1.txt";
            string targetFile = $@"C:\Users\raian\Documents\file{DateTime.Now.Millisecond}.txt";
            FileStream fs = null;
            StreamReader sr = null;

            StreamReader sr2 = null;

            try
            {
                //fs = new FileStream(soucepath, FileMode.Open);
                //sr = new StreamReader(fs);
                sr2 = File.OpenText(soucepath);


                while (!sr2.EndOfStream) {
                    string line2 = sr2.ReadLine();
                    Console.WriteLine(line2);
                }

                string line = sr2.ReadLine();

                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally { 
                if(fs != null) fs.Close();
                if(sr != null) sr.Close();            
            }
        }
    }
}
