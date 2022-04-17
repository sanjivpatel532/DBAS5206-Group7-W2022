using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakeridgeCommunityHospital
{
	class Document
    {
       
            #region PROPERTIES

            public static Document TextFile = new Document();

            public string FileName { get; set; }

            public string Text { get; set; }

            #endregion

            #region CONSTRUCTORS
            /// <summary>
            /// Default Constructor for a document
            /// </summary>
            public Document() { }

            /// <summary>
            /// Parameterized Constructor for a document
            /// </summary>
            /// <param name="text">Text content of the document</param>
            public Document(string fileName, string text)
            {
                // This file name may need to be a filepath
                FileName = fileName;
                Text = text;
            }

            #endregion

            #region OBJECT METHODS

            #endregion

            #region STATIC METHODS
            /// <summary>
            /// Called during save method from text editor form. For writing to a file.
            /// </summary>
            /// <param name="inputFile"></param>
            /// <param name="fileName"></param>
            public static void FileWrite(Document inputFile, String fileName)
            {
                FileStream fsWrite = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                StreamWriter sWriter = new StreamWriter(fsWrite);
                sWriter.Write(FileCreate(inputFile));
                sWriter.Close();
                fsWrite.Close();
            }
            /// <summary>
            /// Called from the FileWrite method, used for extracting contents of Document class
            /// </summary>
            /// <param name="inputFile"></param>
            /// <returns></returns>
            private static String FileCreate(Document inputFile)
            {
                String returnString = string.Empty;

                returnString += inputFile.Text;

                return returnString;
            }
            /// <summary>
            /// Summons a generic document object for storing contents from text file before sending back to main form text editor.
            /// </summary>
            /// <param name="fileName"></param>
            /// <returns></returns>
            public static void LoadFile(String fileName)
            {
                TextFile.Text = string.Empty;
                TextFile.FileName = string.Empty;

                FileStream fileRead = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader streamRead = new StreamReader(fileRead);

                while (!streamRead.EndOfStream)
                {
                    try
                    {
                        TextFile.Text += streamRead.ReadToEnd();
                        TextFile.FileName = fileName;
                    }
                    catch { }
                }

                // Need to close files so that the file will be available to write to (when saving)
                streamRead.Close();
                fileRead.Close();
            }
        }

        #endregion
    
}
