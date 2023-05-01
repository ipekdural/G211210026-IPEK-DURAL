using System;
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
    public partial class nokta_kure : Form
    {
        int control = 0;
        _Point point1 = new _Point();
        Sphere sphere1 = new Sphere();
        public nokta_kure()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            this.Hide();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            noktaKure();
            button2.Enabled = true;


        }
        public void noktaKure()
        {
            sphere1.x = (int)numericUpDown1.Value;
            sphere1.y = (int)numericUpDown2.Value;
            sphere1.z = (int)numericUpDown3.Value;
            sphere1.radius = (int)numericUpDown4.Value;

            point1.x = (int)numericUpDown5.Value;
            point1.y = (int)numericUpDown6.Value;
            point1.z = (int)numericUpDown7.Value;

            double distance = Math.Sqrt(Math.Pow(point1.x - sphere1.x, 2) + Math.Pow(point1.y - sphere1.y, 2) + Math.Pow(point1.z - sphere1.z, 2));
            if (distance <= sphere1.radius)
            {
                MessageBox.Show("Collision has occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                control = 1;
            }
            else
            {
                MessageBox.Show("Collision has not occurred!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        class _Point
        {
            public int x;
            public int y;
            public int z;
        }
        class Sphere
        {
            public int x;
            public int y;
            public int z;
            public int radius;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            draw_point_sphere draw_Point_Sphere = new draw_point_sphere();
            this.Hide();
            draw_Point_Sphere.x = control;
            draw_Point_Sphere.Show();
        }
    }
}
