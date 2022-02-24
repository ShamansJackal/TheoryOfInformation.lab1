using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.IO;

namespace TheoryOfInformation.lab1.Encryptions.Models
{
    public delegate string PythonOperation(string text, string key, string LangId);
    public class BasePythonEnryption
    {
        protected ScriptEngine engine;
        protected ScriptScope scope;
        public BasePythonEnryption()
        {
            engine = Python.CreateEngine();
            ICollection<string> paths = engine.GetSearchPaths();
            paths.Add(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Encryptions", "Python"));
            engine.SetSearchPaths(paths);

            scope = engine.CreateScope();
        }
    }
}
