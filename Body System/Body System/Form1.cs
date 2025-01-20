namespace Body_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsPowerOfTwo(this.Text))
            {

            }
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool IsPowerOfTwo(string s)
        {
            if(int.TryParse(s, out _))
            {
                //2nin kuvveti olup olmadığını kontrol ediyorum
                float i=Convert.ToInt32(s);
                while(i>1)
                {
                    i /= 2;
                    if (i % 1 != 0)
                    {
                        return false;
                    }
                }
                if (i == 1)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
