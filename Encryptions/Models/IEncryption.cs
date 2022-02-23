namespace TheoryOfInformation.lab1.Encryptions.Models
{
    internal interface IEncryption
    {
        string Encrypte(string text, string key);
        string Decrypte(string text, string key);

        bool HasKey { get; }
    }
}
