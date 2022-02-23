using System.Collections.Generic;
using TheoryOfInformation.lab1.Structs;

namespace TheoryOfInformation.lab1.Encryptions
{
    public delegate string Operation(string key, string text);

    public static class TextCleaner
    {
        private static readonly Dictionary<LangIds, string> langs;

        static TextCleaner()
        {
            langs = new Dictionary<LangIds, string>();
            langs[LangIds.RU] = "абвгдеё";
            langs[LangIds.EN] = "abcdefjhklmnop";
        }

        public static string WorkWithText(string key, string text, Operation operation, LangIds lang)
        {
            List<RemovedSymbl> removedSymbls = CleanText(ref text, lang);

            string encodedTxt = operation(key, text);

            return ReturnText(encodedTxt, removedSymbls);
        }

        private static List<RemovedSymbl> CleanText(ref string text, LangIds lang)
        {
            return default;
        }

        private static string ReturnText(string text, List<RemovedSymbl> removedSymbls)
        {
            return text;
        }
    }
}