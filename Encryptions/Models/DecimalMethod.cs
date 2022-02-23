using System;
using TheoryOfInformation.lab1.Structs;

namespace TheoryOfInformation.lab1.Encryptions.Models
{
    public class DecimalMethod : BasePythonEnryption, IEncryption
    {
        public DecimalMethod() : base() { }
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

        public override string ToString() => "Метод децимаций";
    }
}
