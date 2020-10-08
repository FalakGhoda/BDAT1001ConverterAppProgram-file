using ConverterApp.Models;
using System.Text;
using System;
using System.Linq;
using static ConverterApp.Models.Converter;

namespace ConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Falak Ghoda";

            string binaryValue2 = Converter.StringToBinary2(text);

            Console.WriteLine($"Text: {text}\nBinary: {binaryValue2}");



            string binaryValue = Converter.StringToBinary(text);

            Console.WriteLine($"Text: {text}\nBinary: {binaryValue}");



            string textFromBinary = Converter.BinaryToString(binaryValue);

            Console.WriteLine($"Binary: {binaryValue}\nText: {textFromBinary}");


            string hexadecimalValue2 = Converter.StringToHex2(text);

            Console.WriteLine($"Text: {text}\nHEX: {hexadecimalValue2}");

            string hexadecimalValue = Converter.StringToHex(text);

            Console.WriteLine($"Text: {text}\nHEX: {hexadecimalValue}");

            string textFromHex = Converter.HexToString(hexadecimalValue);

            Console.WriteLine($"HEX: {hexadecimalValue}\nText: {textFromHex}");

            string unicodeString = "This string contains the unicode character Pi (\u03a0)";
            int[] cipher = new[] { 1, 1, 2, 3, 5, 8, 13 }; //Fibonacci Sequence
            string cipherasString = String.Join(",", cipher.Select(x => x.ToString())); //FOr display

            int encryptionDepth = 10;

            Encrypter encrypter = new Encrypter(unicodeString, cipher, encryptionDepth);

            //Single Level Encrytion
            string nameEncryptWithCipher = Encrypter.EncryptWithCipher(unicodeString, cipher);
            Console.WriteLine($"Encrypted once using the cipher {{{cipherasString}}} {nameEncryptWithCipher}");

            string nameDecryptWithCipher = Encrypter.DecryptWithCipher(nameEncryptWithCipher, cipher);
            Console.WriteLine($"Decrypted once using the cipher {{{cipherasString}}} {nameDecryptWithCipher}");

            //Deep Encrytion
            string nameDeepEncryptWithCipher = Encrypter.DeepEncryptWithCipher(unicodeString, cipher, encryptionDepth);
            Console.WriteLine($"Deep Encrypted {encryptionDepth} times using the cipher {{{cipherasString}}} {nameDeepEncryptWithCipher}");

            string nameDeepDecryptWithCipher = Encrypter.DeepDecryptWithCipher(nameDeepEncryptWithCipher, cipher, encryptionDepth);
            Console.WriteLine($"Deep Decrypted {encryptionDepth} times using the cipher {{{cipherasString}}} {nameDeepDecryptWithCipher}");

            //Base64 Encoded
            Console.WriteLine($"Base64 encoded {unicodeString} {encrypter.Base64}");

            string base64toPlainText = Encrypter.Base64ToString(encrypter.Base64);
            Console.WriteLine($"Base64 decoded {encrypter.Base64} {base64toPlainText}");
        }
    }
}