using research;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OOP
{
    public partial class Form1 : Form
    {
        bool islogin = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!islogin)
            {

                Connection conn = new Connection();
                string username = userBox.Text;
                string password = passBox.Text;
                if (conn.loginform(username, password))
                {
                    MessageBox.Show("login success");
                    islogin = true;
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                    if (form3.IsDisposed)
                    {
                        Form1 form1 = new Form1();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("login failed");

                }
            }
            else
            {
                MessageBox.Show("You are already logged in");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OOP.Form2 form2 = new OOP.Form2();
            form2.Show();
            if (form2.IsDisposed)
            {
                Form1 form1 = new Form1();
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
