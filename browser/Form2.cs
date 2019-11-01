using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace browser
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            string webPage = textBox1.Text.Trim();
            webBrowser1.Navigate(webPage);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(textBox1.Text);
            }
        }
        public void Navigate(string address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://") &&
                !address.StartsWith("www.")  &&
                !address.StartsWith("youtube"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser1.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }
        private void webBrowser1_Navigated_1(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
        }
    }
}
