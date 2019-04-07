using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SymCryptLab2
{
    class TextPreparing
    {
        public static string GetCleanText()
        {
            string text = System.IO.File.ReadAllText(@"C:\users\nazar\source\repos\SymCryptLab2\SelfCrypting.txt", Encoding.Default).Replace("ё", "е");
            text = Regex.Replace(text, "[^а-яА-Я]", "");
            return text.ToLower();
        }

        public static string GetCypherText()
        {
            string cypherText = System.IO.File.ReadAllText(@"C:\users\nazar\source\repos\SynCryptLab2\ToDecrypt.txt", Encoding.Default);
            return cypherText;
        }

        public static List<char> Alphabet()
        {
            var lst = new List<char>();
            for (int i = 1072; i <= 1103; i++)
                lst.Add(Convert.ToChar(i));
            return lst;
        }
    }
}
