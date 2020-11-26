using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ITMO.CSWF.Lab5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            GraphicsPath path = new GraphicsPath();
            int a = 200;
            int b = 400;

            path.AddLine(a, 0, b, a);
            path.AddLine(b, a, a, b);
            path.AddLine(a, b, 0, a);
            path.AddLine(0, a, a, 0);
            Region myRegion = new Region(path);
            this.Region = myRegion;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
