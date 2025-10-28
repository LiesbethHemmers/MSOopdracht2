namespace MSOopdracht2.Importers
{
    public interface IProgramImporter
    {
        public CodeProgram Import(string filePath);
    }
}