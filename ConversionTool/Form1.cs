using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionTool
{

    public partial class Form1 : Form
    {

        string FileToConvert;
        string SaveLocation;
        string ConvertTo;

        Dictionary<string, string> FileExtention = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            SetupDictionary();
        }

        public void SetupDictionary()
        {
            FileExtention.Add("DXF", "dxf");
            FileExtention.Add("ESRI Shapefile", "shp");
            FileExtention.Add("GeoJSON", "geojson");
            FileExtention.Add("GML", "gml");
            FileExtention.Add("KML","kml");
            FileExtention.Add("Mapinfo File", "tab");
            FileExtention.Add("DGN", "dgn");

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void FindFileToConvert_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FileToConvert = openFileDialog1.FileName;
            textBox1.Text = openFileDialog1.FileName;
        }

        private void ConvertToDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FindSaveLocation_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            SaveLocation = folderBrowserDialog1.SelectedPath.ToString();
            textBox2.Text = folderBrowserDialog1.SelectedPath.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertButton_Click(object sender, EventArgs e) 
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.CreateNoWindow = false;

            startInfo.FileName = "cmd.exe";
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.Arguments = OgrCommand();

            process.StartInfo = startInfo;
            process.Start();
        }

        public string OgrCommand()
        {
            ConvertTo = ConvertToDropDown.SelectedItem.ToString();
            string[] FileStringParts = FileToConvert.Split('\\');
            string[] FileNameParts = FileStringParts[FileStringParts.Length - 1].Split('.');

            return "/C ogr2ogr -f \"" + ConvertTo + "\" \"" + SaveLocation + "\\" + FileNameParts[0] + "." + FileExtention[ConvertTo] + "\" \"" + FileToConvert + "\"";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
