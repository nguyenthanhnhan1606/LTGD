using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form2 f=new Form2();
            f.Hide();
            f.ShowDialog();
           
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if ( result == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
