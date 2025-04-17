using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Class_Testing
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = PictureBox1.CreateGraphics();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Visible = true;
            Bitmap bitmap = new Bitmap(PictureBox1.Width, PictureBox1.Height);
            g.DrawRectangle(new Pen(Color.Black, 3), 10, 50, 100, 100);
            g.DrawLine(new Pen(Color.Red, 3), 10, 10, 110, 110);   
        }
    }
}
