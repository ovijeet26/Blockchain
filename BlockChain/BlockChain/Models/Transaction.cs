using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChain.Models
{
    public class Transaction
    {
        private string _data;

        public Transaction(string data)
        {
            _data = data;
        }

        public string GetTransaction()
        {
            return _data;
        }
    }
}
