using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcess
{
    public class FileReader
    {
        public void Reader()
        {

            new Database.Database().Create();
            new Database.Database().Write();

            return;

            string filePath = @"C:\Users\Mvideo\source\repos\TextProcess\Sport_article.txt";
            string[] words;
            char[] chars = new char[] { ' ', '\r', '\n' };

            using (StreamReader sr = new StreamReader(filePath))
            {
                words = sr.ReadToEnd().Split(chars); 
            }

            Console.WriteLine("!!!!");



        }
    }
}
