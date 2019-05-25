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
    public partial class Start : Form
    {
        
        public static Publisher pub = new Publisher();
        public static List<SendViaEmail> emailList = new List<SendViaEmail>();
        public static List<SendViaMobile> mobileList = new List<SendViaMobile>();
        public static string result;
        public static Start f1 = new Start();
        public static Sub f2 = new Sub(f1, pub);
        public static Pub f3 = new Pub(f1, pub);

        public Start()
        {
            InitializeComponent();
            
        }

        private void Start_Load(object sender, EventArgs e)
        {
            this.Text = "Notification Manager";
            btnPub.Enabled = false;
            //this.Controls.Add(btnPub);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.ShowDialog();
        }

        private void btnPub_Click(object sender, EventArgs e)
        {
            this.Hide();
            f3.ShowDialog();
        }
    }
}
