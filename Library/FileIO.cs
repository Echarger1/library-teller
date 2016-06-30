using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class FileIO : IFileInterface
    {
        public List<string> ReturnMediaFile(string path)
        {
            //initialize the list we'll be returning
            List<string> mediaFile = new List<string>();

            try
            {
                //check to see whether the file exists
                if (!File.Exists(path))
                {
                    //throw appropriate exepction

                        //implement

                }

                //initialize the empty string we'll be using for each line
                string line;

                //open a StreamReader to the file specifcied in the path variable 
                    //implement

                //while reading a new from file, addd each line to mediaFile
                //as long as each new line is not null
                    //implement


                //remember to close your file
                //file.Close();
            }
            catch (FileNotFoundException)
            {
                //write out appropriate message
                Console.WriteLine("File not found");
                    //implement

            }
            catch (Exception e)
            {
                //write out the message of e
                Console.WriteLine("Error ");
                    //implement

            }

            return mediaFile;
        }

        //not yet implemented
        public void UpdateMediaFile(List<string> newMedia)
        {
            throw new NotImplementedException();
        }
    }
}
