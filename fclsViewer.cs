using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_in_24_h__1h
{
    public partial class fclsViewer : Form
    {
        public fclsViewer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofdSelectPicture.ShowDialog() == DialogResult.OK)
            {
                //load the picture into the picture box
                picShowPicture.Image=Image.FromFile(ofdSelectPicture.FileName);
                //show the name of the file in forms caption
                this.Text = String.Concat("Picture Viewer (" + ofdSelectPicture.FileName + ")");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
