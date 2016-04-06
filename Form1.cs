using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class SurfNet : Form
    {
        public SurfNet()
        {
            InitializeComponent();
        }

        // When exit is pressed, this code will execute
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was made my TechCypher on the 6/4/16 using C#.Net");
        }

        private void SurfNet_Load(object sender, EventArgs e)
        {

        }

        

       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //When enter is pressed, navigate
            if( e.KeyChar == (char)ConsoleKey.Enter)
            {
                NavigateToPage();
            }
        }

        

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0 & e.MaximumProgress > 0)
            {
                toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
            }
        }
        #region Faviourites
        // The following code will execute when the user use the favourite option in the tool strip. 
        // It will first navigate to the selected page and then change the address bar to the same page.
        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.github.com");
            textBox1.Text = "http://www.github.com/";
        }

        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.youtube.com");
            textBox1.Text = "http://www.youtube.com/";
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.facebook.com");
            textBox1.Text = "http://www.facebook.com/";
        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.twitter.com");
            textBox1.Text = "http://www.twitter.com/";
        }

        private void redditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.reddit.com");
            textBox1.Text = "http://www.reddit.com/";
        }

        private void amazonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.amazon.co.uk");
            textBox1.Text = "http://www.amazon.co.uk/";
        }

        private void eBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.ebay.com");
            textBox1.Text = "http://www.ebay.com/";
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com");
            textBox1.Text = "http://www.google.com/";
        }
        #endregion

        #region Navigation
        private void NavigateToPage()
        {
            webBrowser1.Navigate(textBox1.Text);
            buttonNavigate.Enabled = false;
            textBox1.Enabled = false;
            toolStripStatusLabel1.Text = "Navigation has started.";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            buttonNavigate.Enabled = true;
            textBox1.Enabled = true;
            toolStripStatusLabel1.Text = "Navigation has complete.";
            textBox1.Text = webBrowser1.Url.OriginalString;
        }

        // When navigate button pressed, website loads.
        private void buttonNavigate_Click(object sender, EventArgs e)
        {
            NavigateToPage();
        }

        //When pressed, the browser will go back
        private void buttonBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        //When pressed, the browser will go forward
        private void buttonForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        //When pressed, the page will stop loading
        private void buttonStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        //When pressed, the page will refresh
        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
        #endregion

    }
}
