using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartForm
{
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = ((Button)sender).Text;

            bool isOpen = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Text == s)
                {
                    isOpen = true;
                    item.Activate();
                    break;
                }
            }

            if (!isOpen)
            {
                Form form = new TitleForm(s);
                form.MdiParent = this;
                form.Show();
            }
        }

        private void CloseFormsButton_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
        }

        private void MdiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
