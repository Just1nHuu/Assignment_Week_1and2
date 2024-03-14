using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_explorer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnforward_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.Url = new Uri(fbd.SelectedPath);
                    txtpath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();

        }

        private void txtpath_TextChanged(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }
    }
}
