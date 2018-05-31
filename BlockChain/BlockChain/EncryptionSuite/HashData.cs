using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BlockChain.Models;

namespace BlockChain.EncryptionSuite
{
    class HashData
    {
        /// <summary>
        /// Hash data using SHA1 algorithm 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string Hash(Transaction data, string previousHash)
        {
            //create new instance of md5
            SHA1 sha1 = SHA1.Create();

            //convert the input text to array of bytes
            byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(FormatDataForHashing(data, previousHash)));

            //create new instance of StringBuilder to save hashed data
            StringBuilder returnValue = new StringBuilder();

            //loop for each byte and add it to StringBuilder
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString());
            }

            // return hexadecimal string
            return returnValue.ToString();
        }
        /// <summary>
        /// Convert data to char array.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static char[] FormatDataForHashing(Transaction list,string previousHash)
        {
            string stringData= list.GetTransaction()+previousHash;
            return stringData.ToCharArray();
        }
    }
}
