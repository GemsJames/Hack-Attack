using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hack_Attack._3_FileManager
{
    public class FileManager
    {
        enum LoadType { Attributes, Contents };

        List<List<string>> attributes = new List<List<string>>();
        List<List<string>> contents = new List<List<string>>();

        List<string> tempAttributes = new List<string>();
        List<string> tempContents = new List<string>();

        public void LoadContent(string filename , List<List<string>> attributes, List<List<string>> contents)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                }
            }
        }

        public void LoadContent(string filename, List<List<string>> attributes, List<List<string>> contents, string identifier)
        {

        }
    }
}
