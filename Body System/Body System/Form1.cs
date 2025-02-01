using Body_System.Tools.Storage;
using System.Windows.Forms;

namespace Body_System
{
    public partial class FormStart : Form
    {
        public static int FullSize;
        public static Storage ram;
        public FormStart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ErrorProvider errorprovider=new ErrorProvider();
            if (int.TryParse(MemorySize.Text, out _))
            {
                float size = Convert.ToInt32(MemorySize.Text);
                if (IsPowerOfTwo(MemorySize.Text) && size <= 256)
                {
                    FullSize = Convert.ToInt32(MemorySize.Text);
                    ram = new Storage(FullSize);
                    FormBodySystem form2 = new FormBodySystem();
                    form2.Show();
                    this.Hide();
                }
                else if (size > 256)
                {
                    errorprovider.SetError(MemorySize, "lutfen 256 degerinden kucuk bir deger giriniz!");
                }
                else
                {
                    errorprovider.SetError(MemorySize, "lutfen 2'nin kuvveti giriniz!");
                }
            }
            else
            {
                errorprovider.SetError(MemorySize, "lutfen sayý degeri giriniz");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool IsPowerOfTwo(string s)
        {
            
                //2nin kuvveti olup olmadýðýný kontrol ediyorum
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
    }
}
