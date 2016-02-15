using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;


namespace Synth1Librarian
{
    public static class Utilities
    {
        public static List<Patch> bankToPatches(Bank bank)
        {
            List<Patch> patchContent = new List<Patch>();
            if (bank.isZipFile)
            {
                patchContent = zipToPatches(bank);
            }
            else
            {
                patchContent = dirToPatches(bank);
            }
            return patchContent;
        }

        // each string in the list will contain the content of the patch file

        public static List<Patch> zipToPatches(Bank zipBank)
        {
            if (File.Exists(zipBank.Path))
            {
                
            }

        }

        public static List<Patch> dirToPatches(Bank dirBank)
        {
            List<Patch> Patches = new List<Patch>();
            if (Directory.Exists(dirBank.Path)
            {
                List<string> filelist = Directory.EnumerateFiles(dirBank.Path).ToList<string>();
                foreach (string patchfile in filelist)
                {
                    string filename = patchfile;
                    if (filename.Substring(0, 2) = "sy")
                    {
                        // we'll consider this a patch
                    }
                }
            }
        }
    }
}
