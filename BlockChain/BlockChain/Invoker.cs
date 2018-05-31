using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlockChain.Models;

namespace BlockChain
{
    class Invoker
    {
        static void Main(string[] args)
        {
            //Seeding the genesis block
            Transaction genesisTransaction=new Transaction("Hmmmmm, so this is where it all starts!");
            Block genesisBlock=new Block("0",genesisTransaction);

            //Creating the first block
            Transaction block1Transaction = new Transaction("Ov paid Gags 1000000$!");
            Block block1 = new Block(genesisBlock.GetHash(), genesisTransaction);

            //Creating the second block
            Transaction block2Transaction = new Transaction("President paid Ov 1000000000$!");
            Block block2 = new Block(block1.GetHash(), genesisTransaction);

            Console.WriteLine("Genesis Block ----->");
            Console.WriteLine(genesisBlock.GetHash()+" -------> "+genesisTransaction.GetTransaction());
            Console.WriteLine("Block 1----->");
            Console.WriteLine(block1.GetHash() + " -------> " + block1Transaction.GetTransaction());
            Console.WriteLine("Block 2----->");
            Console.WriteLine(block2.GetHash() + " -------> " + block2Transaction.GetTransaction());

            Console.ReadKey();
        }
    }
}
    