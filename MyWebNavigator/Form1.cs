using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWebNavigator
{
    public partial class Form1 : Form
    {
        List<string> favorite = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("bing.com");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("bing.com");
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtUrl.Text); 
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            favorite.Add(webBrowser1.Url.ToString());
            actualizarfav();
        }

        private void actualizarfav()
        {
            foreach(string url in favorite)
            {
                toolStripComboBox1.Items.Add(url);
            }
        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripComboBox1.SelectedItem.ToString());
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void txtUrl_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("hola mundo");
        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(txtUrl.Text);
            }
        }
    }
}
