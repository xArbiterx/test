using LabTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestingLab.TestingUnit
{
    public class WordTest
    {
        [Fact]
        public void ReadAndSaveTest()
        {
            WordHelper wordHelper = new WordHelper("aaa.docx");
            wordHelper.Save("aaab.docx");
            
        }
        [Fact]
        public void get()
        {
            WordHelper wordHelper = new WordHelper("aaa.docx");
            wordHelper.GetStyle();

        }
    }
}
