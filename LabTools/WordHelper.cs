using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTools
{
    public class WordHelper
    {
        XWPFDocument Doc;

        public WordHelper()
        {
            Doc = new XWPFDocument();
        }

        public WordHelper(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("The Word dcoument " +
                        filename +
                        " does not exist.");
            }
            FileStream fis = null;
            try
            {
                fis = new FileStream(filename, FileMode.Open);
                Doc = new XWPFDocument(fis);
            }
            finally
            {
                if (fis != null)
                {
                    try
                    {
                        fis.Close();
                        fis.Dispose();
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("IOException caught trying to close " +
                                "FileInputStream in the constructor of " +
                                "WordHelper.");
                    }
                }
            }
        }

        public void Save(string filename)
        {
            using (FileStream sw = File.Create(filename))
            {
                Doc.Write(sw);
            }
        }

        /// <summary>
        /// 标准论文格式段落
        /// </summary>
        /// <param name="para"></param>
        /// <remarks>四号字，中文宋体，ASCII罗马</remarks>
        public static void ConvertPaperParagraphFonts(XWPFParagraph para)
        {
            var run = para.CreateRun();
            CT_Fonts f = run.GetCTR().AddNewRPr().AddNewRFonts();
            f.ascii = "Times New Roman";
            f.eastAsia = "宋体";
            //4号字对应14
            run.FontSize = 14;

            
        }
        
    }
}
