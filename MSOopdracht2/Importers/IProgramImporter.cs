namespace MSOopdracht2.Importers
{
    internal interface IProgramImporter
    {
        public CodeProgram Import(string filePath);
    }
}