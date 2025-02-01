using Body_System.Tools.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_System
{
    public partial class FormBodySystem : Form
    {
        Storage ram = FormStart.ram;
        public FormBodySystem()
        {
            this.Paint += new PaintEventHandler(DrawRam);
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            ErrorProvider errorProvider = new ErrorProvider();
            if (int.TryParse(ProcessNumberTextbox.Text, out _))
            {
                int _Number = Convert.ToInt32(ProcessNumberTextbox);
                if (0 > _Number)    
                {
                    errorProvider.SetError(ProcessNumberTextbox, "Process numarası 0dan kucuk olamaz!");
                }
                else if (ram.IsItUsed(_Number))
                {
                    errorProvider.SetError(ProcessNumberTextbox, "Bu process zaten var!");
                }
                
            }
            else
            {
                errorProvider.SetError(ProcessNumberTextbox, "Gecerli bir numara girin!");
            }
            if(int.TryParse(ProcessSizeTextbox.Text, out _))
            {
                int _Size = Convert.ToInt32(ProcessSizeTextbox.Text);
                if (_Size > 256)
                {
                    errorProvider.SetError(ProcessNumberTextbox, "process boyutu 256dan buyuk olamaz!");
                }
            }
            if(int.TryParse(ProcessTimeTextbox.Text, out _))
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TimeIncrease_Click(object sender, EventArgs e)
        {

        }
        void DrawRam(object sender, PaintEventArgs e)
        {
            for (StorageUnit temp = ram._head; temp != null; temp = temp.Next)
            {
                if (temp.empty == 0)
                {

                }
            }
        }
        private void RedBuild(int _size)
        {

        }
        private void BlueBuild(int _size)
        {

        }
        private void EndPoint()
        {
            Image ımage = Image.FromFile("C:\\Users\\asus\\Desktop\\for me\\Body_System\\Body System\\Body System\\Images\\");
        }
    }
}
