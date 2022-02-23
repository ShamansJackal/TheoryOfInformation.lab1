using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheoryOfInformation.lab1.Structs;

namespace TheoryOfInformation.lab1.Encryptions.Models
{
    public class RowMethod : IEncryption
    {
        public bool HasKey => true;
        public LangIds Lang => LangIds.EN;

        public string Decrypte(string text, string key)
        {
            throw new NotImplementedException();
        }

        public string Encrypte(string text, string key)
        {
            throw new NotImplementedException();
        }

        public override string ToString() => "Cтолбцовый метод";
    }
}
