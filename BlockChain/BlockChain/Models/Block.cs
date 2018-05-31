using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlockChain.EncryptionSuite;

namespace BlockChain.Models
{
    public class Block
    {
        private string _previousHash;
        private Transaction _transaction;
        private string _blockHash;
        public Block(string previousHash, Transaction transaction)
        {
            _previousHash = previousHash;
            _transaction = transaction;
            _blockHash = GenerateHash(transaction, previousHash);
        }

        private string GenerateHash(Transaction t, string pH)
        {
           return HashData.Hash(t, pH);
        }

        public string GetTransactionData()
        {
            return _transaction.GetTransaction();
        }
        public string GetHash()
        {
            return _blockHash;
        }
    }
}
