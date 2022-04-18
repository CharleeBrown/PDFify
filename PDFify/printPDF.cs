using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PdfSharp.SharpZipLib;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Internal;
using PdfSharp.Fonts;


namespace PDFify
{
    internal class printPDF
    {
   
    class getPDF
        {
            /*<summary>
            Select the folder with documents
            The application turns the documents into PDFs
            The application creates a folder in the same location
            This new folder has all the PDF'd documents.
            </summary>*/
            public void createPDF(string filepath, string watermark, string userfile, int fontSize, string destination)
            {
            
                {
                    // Creates a new file path to save the watermarked PDF.
                    string newFileName = destination + @"\" + userfile + ".pdf";

                    // Opens the file from the path provided.
                    PdfDocument document = PdfReader.Open(filepath);

                    // Counts the amount of pages in the PDF. 
                    PdfPages pages = document.Pages;

                    // Sets the first page as the page to work on. 
                    PdfPage page = document.Pages[0];

                    // Saves it in the provided location. 
                    document.Save(newFileName);
                   
                        // Alerts the user that the file was saved and creates an explorer window of the destination.
                        System.Diagnostics.Process.Start("explorer.exe", destination);
                    
                }
            }
        }
    }

}
    }
}
