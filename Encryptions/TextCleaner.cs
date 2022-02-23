using System.Collections.Generic;
using TheoryOfInformation.lab1.Structs;

namespace TheoryOfInformation.lab1.Encryptions
{
    public delegate string Operation(string key, string text);

    public static class TextCleaner
    {
        public static string WorkWithText(string key, string text, Operation operation)
        {
            List<RemovedSymbl> removedSymbls = CleanText(ref text);

            string encodedTxt = operation(key, text);

            return ReturnText(encodedTxt, removedSymbls);
        }

        private static List<RemovedSymbl> CleanText(ref string text)
        {
            return default;
        }

        private static string ReturnText(string text, List<RemovedSymbl> removedSymbls)
        {
            return text;
        }
    }
}