namespace ConversionTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FindFileToConvert = new System.Windows.Forms.Button();
            this.ConvertToDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FindSaveLocation = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FindFileToConvert
            // 
            this.FindFileToConvert.Location = new System.Drawing.Point(110, 48);
            this.FindFileToConvert.Name = "FindFileToConvert";
            this.FindFileToConvert.Size = new System.Drawing.Size(75, 23);
            this.FindFileToConvert.TabIndex = 4;
            this.FindFileToConvert.Text = "Browse";
            this.FindFileToConvert.UseVisualStyleBackColor = true;
            this.FindFileToConvert.Click += new System.EventHandler(this.FindFileToConvert_Click);
            // 
            // ConvertToDropDown
            // 
            this.ConvertToDropDown.FormattingEnabled = true;
            this.ConvertToDropDown.Items.AddRange(new object[] {
            "DXF",
            "ESRI Shapefile",
            "GeoJSON",
            "GML",
            "KML",
            "Mapinfo File",
            "DGN"});
            this.ConvertToDropDown.Location = new System.Drawing.Point(87, 18);
            this.ConvertToDropDown.Name = "ConvertToDropDown";
            this.ConvertToDropDown.Size = new System.Drawing.Size(121, 24);
            this.ConvertToDropDown.TabIndex = 5;
            this.ConvertToDropDown.SelectedIndexChanged += new System.EventHandler(this.ConvertToDropDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "To format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "File Location";
            // 
            // FindSaveLocation
            // 
            this.FindSaveLocation.Location = new System.Drawing.Point(110, 77);
            this.FindSaveLocation.Name = "FindSaveLocation";
            this.FindSaveLocation.Size = new System.Drawing.Size(75, 23);
            this.FindSaveLocation.TabIndex = 8;
            this.FindSaveLocation.Text = "Browse";
            this.FindSaveLocation.UseVisualStyleBackColor = true;
            this.FindSaveLocation.Click += new System.EventHandler(this.FindSaveLocation_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(307, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(16, 107);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(168, 23);
            this.ConvertButton.TabIndex = 11;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Save Location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 144);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FindSaveLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConvertToDropDown);
            this.Controls.Add(this.FindFileToConvert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button FindFileToConvert;
        private System.Windows.Forms.ComboBox ConvertToDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FindSaveLocation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label label3;
    }
}

