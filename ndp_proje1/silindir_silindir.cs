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
    public partial class silindir_silindir : Form
    {
        Cylinder cylinder1 = new Cylinder();
        Cylinder cylinder2 = new Cylinder();
        public int control = 0;
        public silindir_silindir()
        {
            InitializeComponent();
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

            silindirSilindir();
            button2.Enabled = true;

        }
        public void silindirSilindir()
        {
            cylinder1.x = (int)numericUpDown1.Value;
            cylinder1.y = (int)numericUpDown2.Value;
            cylinder1.z = (int)numericUpDown3.Value;
            cylinder1.radius = (int)numericUpDown4.Value;
            cylinder1.height = (int)numericUpDown5.Value;

            cylinder2.x = (int)numericUpDown6.Value;
            cylinder2.y = (int)numericUpDown7.Value;
            cylinder2.z = (int)numericUpDown8.Value;
            cylinder2.radius = (int)numericUpDown9.Value;
            cylinder2.height = (int)numericUpDown10.Value;
            float distance = (float)Math.Sqrt(Math.Pow(cylinder2.x - cylinder1.x, 2) + Math.Pow(cylinder2.y - cylinder1.y, 2) + Math.Pow(cylinder2.z - cylinder1.z, 2));
            if (cylinder1.radius + cylinder2.radius > distance)
            {

                double d = Math.Sqrt(Math.Pow(cylinder2.x - cylinder1.x, 2) + Math.Pow(cylinder2.y - cylinder1.y, 2) + Math.Pow(cylinder2.z - cylinder1.z, 2));
                double nx = (cylinder2.x - cylinder1.x) / d;
                double ny = (cylinder2.y - cylinder1.y) / d;
                double nz = (cylinder2.z - cylinder1.z) / d;

                double px1 = cylinder1.x + nx * cylinder1.radius;
                double py1 = cylinder1.y + ny * cylinder1.radius;
                double pz1 = cylinder1.z + nz * cylinder1.radius;

                double px2 = cylinder2.x - nx * cylinder2.radius;
                double py2 = cylinder2.y - ny * cylinder2.radius;
                double pz2 = cylinder2.z - nz * cylinder2.radius;

                if (Math.Pow(px2 - px1, 2) + Math.Pow(py2 - py1, 2) + Math.Pow(pz2 - pz1, 2) < Math.Pow(cylinder2.radius, 2))
                {

                    MessageBox.Show("Collision has occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    control = 1;

                }
                else
                {
                    // The cylinders are not overlapping, but they are still colliding if their axis intersect.
                    double a = Math.Pow(cylinder2.x - cylinder1.x, 2) + Math.Pow(cylinder2.y - cylinder1.y, 2);
                    double b = 2 * ((cylinder2.x - cylinder1.x) * (cylinder1.x - px1) + (cylinder2.y - cylinder1.y) * (cylinder1.y - py1));
                    double c = px1 * px1 + py1 * py1 + cylinder1.x * cylinder1.x + cylinder1.y * cylinder1.y - 2 * (px1 * cylinder1.x + py1 * cylinder1.y) - Math.Pow(cylinder1.radius, 2);

                    double discriminant = b * b - 4 * a * c;

                    if (discriminant < 0)
                    {
                        MessageBox.Show("Collision has not occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show("Collision has occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control = 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Collision has not occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            draw_cylinder_cylinder d = new draw_cylinder_cylinder();
            d.x = control;
            this.Hide();
            d.Show();
        }
    }
}
