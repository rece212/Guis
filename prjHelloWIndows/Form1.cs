namespace prjHelloWIndows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPressMe_Click(object sender, EventArgs e)
        {
            String strInput = txtOutput.Text;
            lblOutput.Text = strInput;

            if (rbSelect.Checked)
            {
                rtbTestOneTwoThree.Text = "Radio button was selected\n\nTest one two three";
            }
            else if (cbTest.Checked)
            {
                rtbTestOneTwoThree.Text = "Check box is checked";
            }
            else
                rtbTestOneTwoThree.Text = "Don't you like me anymore";


        }
    }
}
