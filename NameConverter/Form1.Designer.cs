namespace NameConverter
{
    partial class BaseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UpperCamelTextBox = new System.Windows.Forms.TextBox();
            this.LowerCamelTextBox = new System.Windows.Forms.TextBox();
            this.UpperKebabTextBox = new System.Windows.Forms.TextBox();
            this.LowerKebabTextBox = new System.Windows.Forms.TextBox();
            this.AllUpperKebabTextBox = new System.Windows.Forms.TextBox();
            this.TopMostCheckBox = new System.Windows.Forms.CheckBox();
            this.OriginalTextBox = new System.Windows.Forms.TextBox();
            this.TargetTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpperCamelTextBox
            // 
            this.UpperCamelTextBox.Location = new System.Drawing.Point(12, 110);
            this.UpperCamelTextBox.Name = "UpperCamelTextBox";
            this.UpperCamelTextBox.Size = new System.Drawing.Size(125, 27);
            this.UpperCamelTextBox.TabIndex = 0;
            this.UpperCamelTextBox.TextChanged += new System.EventHandler(this.UpperCamelTextBox_TextChanged);
            // 
            // LowerCamelTextBox
            // 
            this.LowerCamelTextBox.Location = new System.Drawing.Point(12, 167);
            this.LowerCamelTextBox.Name = "LowerCamelTextBox";
            this.LowerCamelTextBox.Size = new System.Drawing.Size(125, 27);
            this.LowerCamelTextBox.TabIndex = 1;
            this.LowerCamelTextBox.TextChanged += new System.EventHandler(this.LowerCamelTextBox_TextChanged);
            // 
            // UpperKebabTextBox
            // 
            this.UpperKebabTextBox.Location = new System.Drawing.Point(12, 220);
            this.UpperKebabTextBox.Name = "UpperKebabTextBox";
            this.UpperKebabTextBox.Size = new System.Drawing.Size(125, 27);
            this.UpperKebabTextBox.TabIndex = 2;
            this.UpperKebabTextBox.TextChanged += new System.EventHandler(this.UpperKebabTextBox_TextChanged);
            // 
            // LowerKebabTextBox
            // 
            this.LowerKebabTextBox.Location = new System.Drawing.Point(12, 273);
            this.LowerKebabTextBox.Name = "LowerKebabTextBox";
            this.LowerKebabTextBox.Size = new System.Drawing.Size(125, 27);
            this.LowerKebabTextBox.TabIndex = 3;
            this.LowerKebabTextBox.TextChanged += new System.EventHandler(this.LowerKebabTextBox_TextChanged);
            // 
            // AllUpperKebabTextBox
            // 
            this.AllUpperKebabTextBox.Location = new System.Drawing.Point(12, 326);
            this.AllUpperKebabTextBox.Name = "AllUpperKebabTextBox";
            this.AllUpperKebabTextBox.Size = new System.Drawing.Size(125, 27);
            this.AllUpperKebabTextBox.TabIndex = 4;
            this.AllUpperKebabTextBox.TextChanged += new System.EventHandler(this.AllUpperKebabTextBox_TextChanged);
            // 
            // chkTopMost
            // 
            this.TopMostCheckBox.AutoSize = true;
            this.TopMostCheckBox.Location = new System.Drawing.Point(12, 12);
            this.TopMostCheckBox.Name = "chkTopMost";
            this.TopMostCheckBox.Size = new System.Drawing.Size(61, 24);
            this.TopMostCheckBox.TabIndex = 5;
            this.TopMostCheckBox.Text = "置顶";
            this.TopMostCheckBox.UseVisualStyleBackColor = true;
            this.TopMostCheckBox.CheckedChanged += new System.EventHandler(this.TopMostCheckBox_CheckedChanged);
            // 
            // OriginalTextBox
            // 
            this.OriginalTextBox.Location = new System.Drawing.Point(269, 75);
            this.OriginalTextBox.Multiline = true;
            this.OriginalTextBox.Name = "OriginalTextBox";
            this.OriginalTextBox.Size = new System.Drawing.Size(253, 363);
            this.OriginalTextBox.TabIndex = 6;
            this.OriginalTextBox.TextChanged += new System.EventHandler(this.OriginalTextBox_TextChanged);
            // 
            // TargetTextBox
            // 
            this.TargetTextBox.Location = new System.Drawing.Point(528, 75);
            this.TargetTextBox.Multiline = true;
            this.TargetTextBox.Name = "TargetTextBox";
            this.TargetTextBox.Size = new System.Drawing.Size(260, 363);
            this.TargetTextBox.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "json",
            "xml"});
            this.comboBox1.Location = new System.Drawing.Point(322, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "java",
            "c#"});
            this.comboBox2.Location = new System.Drawing.Point(578, 10);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 28);
            this.comboBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "大驼峰";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "小驼峰";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "大下划线";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "小下划线";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "全大下划线";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TargetTextBox);
            this.Controls.Add(this.OriginalTextBox);
            this.Controls.Add(this.TopMostCheckBox);
            this.Controls.Add(this.AllUpperKebabTextBox);
            this.Controls.Add(this.LowerKebabTextBox);
            this.Controls.Add(this.UpperKebabTextBox);
            this.Controls.Add(this.LowerCamelTextBox);
            this.Controls.Add(this.UpperCamelTextBox);
            this.Name = "BaseForm";
            this.Text = "常用格式转换器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UpperCamelTextBox;
        private TextBox LowerCamelTextBox;
        private TextBox UpperKebabTextBox;
        private TextBox LowerKebabTextBox;
        private TextBox AllUpperKebabTextBox;
        private CheckBox TopMostCheckBox;
        private TextBox OriginalTextBox;
        private TextBox TargetTextBox;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}