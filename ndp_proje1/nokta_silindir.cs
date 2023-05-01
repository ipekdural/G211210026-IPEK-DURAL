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
    public partial class nokta_silindir : Form
    {
        public int control = 0;
        Cylinder cylinder1 = new Cylinder();
        _Point point1 = new _Point();
        public nokta_silindir()
        {
            InitializeComponent();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
        public void noktaSilindir()
        {
            point1.x = (int)numericUpDown1.Value;
            point1.y = (int)numericUpDown2.Value;
            point1.z = (int)numericUpDown3.Value;
            cylinder1.x = (int)numericUpDown4.Value;
            cylinder1.y = (int)numericUpDown5.Value;
            cylinder1.z = (int)numericUpDown6.Value;
            cylinder1.radius = (int)numericUpDown7.Value;
            cylinder1.height = (int)numericUpDown8.Value;
            if ((cylinder1.x != 0) && (cylinder1.y != 0) && (cylinder1.z != 0))
            {

                float distance = (float)Math.Sqrt(Math.Pow(point1.x - cylinder1.x, 2) + Math.Pow(point1.y - cylinder1.y, 2) + Math.Pow(point1.z - cylinder1.z, 2));
                float izdusum = ((point1.x - cylinder1.x) * cylinder1.x + (point1.y - cylinder1.y) * cylinder1.y + (point1.z - cylinder1.z) * cylinder1.z) / (cylinder1.x * cylinder1.x + cylinder1.y * cylinder1.y + cylinder1.z * cylinder1.z);
                float closestx = cylinder1.x * izdusum;
                float closesty = cylinder1.y * izdusum;
                float closestz = cylinder1.z * izdusum;

                float distToAxis = (float)Math.Sqrt(Math.Pow(point1.x - closestx, 2) + Math.Pow(point1.y - closesty, 2) + Math.Pow(point1.z - closestz, 2)
               );
                if (distance <= cylinder1.radius && Math.Abs(izdusum) <= cylinder1.height / 2 && distToAxis <= cylinder1.radius)
                {


                    MessageBox.Show("Collision has occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    control = 1;
                }
                else
                {

                    MessageBox.Show("Collision has not occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
            }
            else
            {
                MessageBox.Show("Please enter the value of x y z coordinate of cylinder except 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                control = 0;
            }

        }
        class Cylinder
        {
            public int x;
            public int y;
            public int z;
            public float radius;
            public float height;
        }
        class _Point
        {
            public int x;
            public int y;
            public int z;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            noktaSilindir();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            draw_point_cylinder d = new draw_point_cylinder();
            d.x = control;
            this.Hide();
            d.Show();
        }
    }
}
