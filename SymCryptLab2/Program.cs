using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymCryptLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Crypted text = {Encrypting.encryptText(3)}");
            //Console.WriteLine(TextPreparing.GetCleanText());
            //Console.WriteLine(Convert.ToInt32('а'));
            //string cypherText = Encrypting.encryptText(4);
            //string key = Encrypting.key;
            //Console.WriteLine($"Decrypted text = {Encrypting.decryptText(cypherText, key)}");
            string cypherText = Encrypting.encryptText(2);
            Console.WriteLine(Encrypting.Index());
            cypherText = Encrypting.encryptText(3);
            Console.WriteLine(Encrypting.Index());
            cypherText = Encrypting.encryptText(4);
            Console.WriteLine(Encrypting.Index());
            cypherText = Encrypting.encryptText(5);
            Console.WriteLine(Encrypting.Index());
            cypherText = Encrypting.encryptText(10);
            Console.WriteLine(Encrypting.Index());
            cypherText = Encrypting.encryptText(20);
            Console.WriteLine(Encrypting.Index());
            Console.ReadKey();
        }
    }
}
