
using System.IO;


namespace Tests.Artefacts
{
    public static class Artefact
    {
        public static FileStream Load(string filename)
        {
            return new FileStream($"artefacts/{filename}", FileMode.Open);
        }
    }
}