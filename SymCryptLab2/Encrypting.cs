using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymCryptLab2
{
    class Encrypting
    {
        public static string cypherText = "";
        public static string key = "";
        public static string GetKey(int len)
        {
            string genKey = "";
            var alphabet = TextPreparing.Alphabet();
            var rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < len; i++)
            {
                int ticks = rnd.Next(0, 32);
                genKey += alphabet[ticks]; 
            }
            return genKey;
        }

        public static string encryptText(int keylen)
        {
            key = GetKey(keylen);
            var text = TextPreparing.GetCleanText();

            for(int i = 0; i < text.Length; i++)
            {
                int h = key[i % keylen] - 1072;
                cypherText += Convert.ToChar(((Convert.ToInt32(text[i]) % 1072 + h) % 32) + 1072); 
            }
            return cypherText;
        }

        public static string decryptText(string cypherText, string key)
        {
            string message = "";
            for(int i = 0; i < cypherText.Length; i++)
            {
                int h = key[i % key.Length] - 1072;
                message += Convert.ToChar((((Convert.ToInt32(cypherText[i]) + 32) % 1072 - h) % 32) + 1072);
            }
            return message;
        }

        public static Dictionary<char, int> countSymbol(string cypheText)
        {
            var alphabet = TextPreparing.Alphabet();
            var monograms = new Dictionary<char, int>();
            foreach(var letter in alphabet)
            {
                monograms.Add(letter, 0);
            }
            foreach(var letter in cypheText)
            {
                monograms[letter]++;
            }
            return monograms;
        }
        public static double Index()
        {
            double index;
            double sum = 0;
            var monograms = countSymbol(cypherText);
            foreach(var letter in monograms)
            {
                sum += letter.Value * (letter.Value - 1); 
            }
            index = sum / (cypherText.Length * (cypherText.Length - 1));
            return index;
        }
    }
}
