using System.IO;

namespace Web2geter
{
    class GetFilePath
    {
        public string MakeFilePath(string dirName)
        {
           if (!Directory.Exists(dirName))
           {
                Directory.CreateDirectory(dirName);
           }
            var workdir = Directory.GetCurrentDirectory();
            var filepCombine = Path.Combine(workdir, dirName);
            return filepCombine;
        }
    }
}