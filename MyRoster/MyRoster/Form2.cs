using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRoster
{
    public partial class Form2 : Form
    {
        public Form2(string url)
        {
            InitializeComponent();
            WebBrowser webBrowser2 = new WebBrowser();
            this.webBrowser2.Navigate(url);
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
