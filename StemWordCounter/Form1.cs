using System;
using System.Windows.Forms;

namespace StemWordCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Simple front-end to perform stemming & count
            textBox1.Text = "Friends are friendlier friendlies that are friendly and classify the friendly classification class. Flowery flowers flow through following the flower flows.";

            comboBox1.Items.Add("following");
            comboBox1.Items.Add("flow");
            comboBox1.Items.Add("classification");
            comboBox1.Items.Add("class");
            comboBox1.Items.Add("flower");
            comboBox1.Items.Add("friend");
            comboBox1.Items.Add("friendly");
            comboBox1.Items.Add("classes");

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
  
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Stem ostem = new Stem();
            //show the stem word for the given word
            textBox2.Text = ostem.WordStem(comboBox1.Text);
            //display count the matches of input text stem words against the given stem.
            textBox3.Text = ostem.CountStems(textBox1.Text,comboBox1.Text).ToString();

        }
    }
}
