using System;

namespace NameConverter
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void UpperCamelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (UpperCamelTextBox.Text.Length > 0)
            {
                LowerCamelTextBox.Text = string.Concat(UpperCamelTextBox.Text.First().ToString().ToLower(), UpperCamelTextBox.Text.AsSpan(1));
                
            }
        }

        private void LowerKebabTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LowerKebabTextBox.Text.Length > 0)
            {
                AllUpperKebabTextBox.Text = LowerKebabTextBox.Text.First().ToString().ToLower() + LowerKebabTextBox.Text.Substring(1);
            }
        }

        private void AllUpperKebabTextBox_TextChanged(object sender, EventArgs e)
        {
            var arr = AllUpperKebabTextBox.Text.Split("_");
            var str = "";
            foreach (var item in arr)
            {
                if (item.Length > 0)
                {
                    str += item.First().ToString().ToUpper() + item.Substring(1).ToLower();
                }
            }
            UpperCamelTextBox.Text = str;
            if (str.Length > 0)
            {
                str = str.First().ToString().ToLower() + str.Substring(1);
            }

            LowerCamelTextBox.Text = str;

        }

        private void TopMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TopMostCheckBox.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void OriginalTextBox_TextChanged(object sender, EventArgs e)
        {
            //TargetTextBox.Text = "";
            //foreach (string line in OriginalTextBox.Lines)
            //{
            //    string str = line.Trim();
            //    string newLine = "";
            //    string varName = "";
            //    var strs = str.Split(' ');
            //    if (strs.Length > 2)
            //    {
            //        varName = strs[2].ToString();


            //        var arr = varName.Split("_");
            //        var str2 = "";
            //        foreach (var item in arr)
            //        {
            //            if (item.Length > 0)
            //                str2 += item.First().ToString().ToUpper() + item.Substring(1).ToLower();

            //        }
            //        varName = str2;

            //    }
            //    else
            //    {
            //        continue;
            //    }


            //    TargetTextBox.Text += strs[0] + " " + strs[1] + " " + varName;
            //    varName = varName.First().ToString().ToLower() + varName.Substring(1);
            //TargetTextBox.Text += "/**\r\n";
            //TargetTextBox.Text += "*\r\n";
            //TargetTextBox.Text += "*/\r\n";
            //TargetTextBox.Text += "@XmlElement(name = \"" + strs[2] + "\")";
            //TargetTextBox.Text += strs[0] + " " + strs[1] + " " + varName + "\r\n";


            //}

        }

        private void LowerCamelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LowerCamelTextBox.Text.Length > 0)
            {
                UpperCamelTextBox.Text = LowerCamelTextBox.Text.First().ToString().ToUpper() + LowerCamelTextBox.Text.Substring(1);
            }
        }

        private void UpperKebabTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}