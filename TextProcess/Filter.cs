using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcess
{
    public class Filter // internal - не наследуется 
    {
        private char[] _symbols = new[] { '.', ',', '—', '*', '\'', '\"', '«', '»', ':', '!', '?', ';', '(', ')' };
        public string DeleteSymbols (string word)
        {
            return word.Trim(_symbols);
        }


        // hren
        public bool CheckWordLenght (string word)
        {
            if (word.Length < 3)
                return false;
            return true;

        }


    }
}
