using System;
using TheoryOfInformation.lab1.Structs;

namespace TheoryOfInformation.lab1.Encryptions.Models
{
    public class VijenerProgKey : BasePythonEnryption, IEncryption
    {
        public VijenerProgKey() : base() { }

        public LangIds Lang => LangIds.RU;

        public string Decrypte(string text, string key)
        {
            throw new NotImplementedException();
        }

        public string Encrypte(string text, string key)
        {
            throw new NotImplementedException();
        }

        public override string ToString() => "Виженера, прогрессивный ключ";
    }
}
