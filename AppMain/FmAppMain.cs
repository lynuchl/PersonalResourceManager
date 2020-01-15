using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMain
{
    public partial class FmAppMain : Form
    {
        public FmAppMain()
        {
            InitializeComponent();
            //this.Visible = false;
        }

        private void noteBookItem_Click(object sender, EventArgs e)
        {
            //隐藏主窗体
            //this.Hide();
            //this.Close();
            DialogResult dialogResult = new NoteBook.noteBookMain().ShowDialog();

            //new NoteBook.noteBookMain().Show();


        }
    }
}
