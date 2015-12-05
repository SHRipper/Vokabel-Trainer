using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vokabel_Trainer
{
    class VocabFile
    {
        public static string path;
        public static int linesInFile;

        public static void getTotalLines()
        {
            linesInFile = 0;
            StreamReader sr = new StreamReader(VocabFile.path);
            while (sr.ReadLine() != null)
            {
                linesInFile++;
            }
            sr.Close();
        }
    }
}
