using Newtonsoft.Json;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Resume_Creator
{
    public partial class ResumeCreator : Form
    {
        public ResumeCreator()
        {
            InitializeComponent();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

        }

        private void OpenFilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog() { Filter = "json file|*.json", };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string file = openFile.FileName;
                string json = File.ReadAllText(file);
                Information resultResume = JsonConvert.DeserializeObject<Information>(json);
                InfoBox.Text = resultResume.ToString();
            }
    }
}