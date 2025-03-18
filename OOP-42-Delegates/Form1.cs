namespace OOP_42_Delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // metod imzaları aynı dönüş tipleri aynı
            // c# için metod adının hiçbir önemi yoktur. c# için önemli olan metodun imzası ve geri dönüş tipidir.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EventHandler handler = null;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
