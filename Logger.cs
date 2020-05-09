using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xtractor
{
    class Logger
    {
        public static void reset_log(string filename) {
            try
            {
                System.IO.File.Delete(filename);
            }
            catch (System.IO.FileNotFoundException eer) { 
                
            }
        }

        public static void log(string filename, string message )
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, true))
            {
                file.WriteLine(message);
            }

        }
    }
}
