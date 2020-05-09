using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xtractor
{
    class FoFiWorker
    {
   
        public static string perform_FoFicopy(String exclude, String source, String destination, bool move = true, bool overwrite = false, bool includedir = false)
        {

            string destination_filename = destination + "\\" + Path.GetFileNameWithoutExtension(source) + Path.GetExtension(source);

            if (includedir)
            {
                //Console.WriteLine(source.Substring(exclude.Length + 1).Replace("\\", "__"));
                destination_filename = destination + "\\" + source.Substring(exclude.Length + 1).Replace("\\", "__");
            }

            try
            {
                File.Copy(source, destination_filename, overwrite);
                if (!move) // if retain is unchecked, delete the source
                {
                    File.Delete(source);
                }
            }
            catch (System.IO.IOException eer)
            {

            }

            return Path.GetFileName(destination_filename);
        }


    }
}
