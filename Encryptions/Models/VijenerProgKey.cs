using System;
using System.IO;
using TheoryOfInformation.lab1.Structs;

namespace TheoryOfInformation.lab1.Encryptions.Models
{
    public class VijenerProgKey : BasePythonEnryption, IEncryption
    {
        public VijenerProgKey() : base() { }

        public LangIds Lang => LangIds.RU;
        public LangIds KeyLang => LangIds.RU;

        public string Decrypte(string text, string key)
        {
            engine.ExecuteFile(Path.Combine(basePath, "VijenerPorgKey.py"), scope);
            PythonOperation decrypte = scope.GetVariable<PythonOperation>("Decrypte");

            return decrypte(text, key, Enum.GetName(typeof(LangIds), Lang));
        }

        public string Encrypte(string text, string key)
        {
            engine.ExecuteFile(Path.Combine(basePath, "VijenerPorgKey.py"), scope);
            PythonOperation encrypte = scope.GetVariable<PythonOperation>("Encrypte");

            return encrypte(text, key, Enum.GetName(typeof(LangIds), Lang));
        }

        public override string ToString() => "Виженера, прогрессивный ключ";
    }
}
