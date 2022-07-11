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
        class Information
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Contact { get; set; }
            public string Objective { get; set; }
            public string Address { get; set; }
            public string Elementary { get; set; }
            public string JuniorHighSchool { get; set; }
            public string SeniorHighSchool { get; set; }
            public string College { get; set; }
            public string ElementaryA { get; set; }
            public string JuniorHighSchoolA { get; set; }
            public string Hobbies { get; set; }
            public override string ToString()
            {
                return string.Format("\nName: {0} \nEmail: {1} \nContact: {2} \nAddress: {4} \n\n {3} \n\nEducational Attainment \nElementary: {5} \nHigh School: {6} \nSenior High School: {7} \nCollege: {8} \n\nEducational Achievements \nElementary Achievement: {9} \nJunior HighSchool: {10} \n\nSkills: {11}",
                        Name, Email, Contact, Objective, Address, Elementary, JuniorHighSchool, SeniorHighSchool, College, ElementaryA, JuniorHighSchoolA, string.Join("", Hobbies.ToArray()));
            }
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
}