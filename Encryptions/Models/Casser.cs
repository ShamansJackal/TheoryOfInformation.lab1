using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoryOfInformation.lab1.Encryptions.Models
{
    internal class Casser : IEncryption
    {
        public bool HasKey => false;

        public string Decrypte(string text, string key)
        {
            throw new NotImplementedException();
        }

        public string Encrypte(string text, string key)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Цезарь";
        }
    }
}
