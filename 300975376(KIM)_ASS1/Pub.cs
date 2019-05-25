using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300975376_Kim_ASS1
{
    public partial class Pub : Form
    {
        public Pub(Start f1, Publisher pub)
        {
            InitializeComponent();
            this.Text = "Publish Notification";
        }

        private void Pub_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPub_Click(object sender, EventArgs e)
        {
            Start.pub.PublishMessage(textNotiContent.Text);
            System.Windows.Forms.MessageBox.Show(Start.result);
        }


    }
}
