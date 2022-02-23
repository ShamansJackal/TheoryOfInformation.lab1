using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace TheoryOfInformation.lab1.Encryptions.Models
{
    public class BasePythonEnryption
    {
        protected ScriptEngine engine;
        protected ScriptScope scope;
        public BasePythonEnryption()
        {
            engine = Python.CreateEngine();
            scope = engine.CreateScope();
        }
    }
}
