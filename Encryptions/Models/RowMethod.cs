using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheoryOfInformation.lab1.Structs;

namespace TheoryOfInformation.lab1.Encryptions.Models
{
    public class RowMethod : BasePythonEnryption, IEncryption
    {
        public LangIds Lang => LangIds.EN;

        public string Decrypte(string text, string key)
        {
            throw new NotImplementedException();
        }

        public string Encrypte(string text, string key)
        {
            engine.ExecuteFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Encryptions", "Python", "RowMethod.py"), scope);
            PythonOperation encrypte = scope.GetVariable<PythonOperation>("Encrypte");

            return encrypte(text, key, Enum.GetName(typeof(LangIds), Lang));
        }

        public override string ToString() => "Cтолбцовый метод";
    }
}
