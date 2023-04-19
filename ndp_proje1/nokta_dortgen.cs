﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ndp_proje1
{


    public partial class nokta_dortgen : Form
    {
        Rectangle rectangle1 = new Rectangle();
        _Point point1 = new _Point();

        public nokta_dortgen()
        {
            InitializeComponent();
        }

        private void nokta_dortgen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            point1.x = (int)numericUpDown1.Value;
            point1.y = (int)numericUpDown2.Value;

            rectangle1.x = (int)numericUpDown3.Value;
            rectangle1.y = (int)numericUpDown4.Value;
            rectangle1.height = (int)numericUpDown5.Value;
            rectangle1.width = (int)numericUpDown6.Value;
            DrawShapes();
            noktaDortgen();


        }

        public void noktaDortgen()
        {

            if (point1.x < rectangle1.x || point1.x > rectangle1.x + rectangle1.width || point1.y < rectangle1.y || point1.y > rectangle1.y + rectangle1.height)
            {
                MessageBox.Show("Collision has not occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Collision has  occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void DrawShapes()
        {


            panel1.Refresh();


            Graphics g = panel3.CreateGraphics();
            g.ScaleTransform(2, 2); // X ve Y ekseni boyutlarını 2 kat artırır
            g.FillEllipse(Brushes.Green, point1.x, point1.y, 5, 5);

            g.DrawRectangle(Pens.Red, rectangle1.x, rectangle1.y, rectangle1.width, rectangle1.height);





            g.Dispose();
        }

        public class Rectangle
        {
            public int x;
            public int y;
            public int width;
            public int height;
        }
        public class _Point
        {
            public int x;
            public int y;
        }
    }

}