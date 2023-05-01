using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ndp_proje1.nokta_dortgen;

namespace ndp_proje1
{
    public partial class nokta_cember : Form
    {
        public int control = 0;
        _Point point1 = new _Point();
        Circle circle1 = new Circle();
        public nokta_cember()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            noktaCember();
        }
        public void noktaCember()
        {
            point1.x = (int)numericUpDown1.Value;
            point1.y = (int)numericUpDown2.Value;

            circle1.x = (int)numericUpDown3.Value;
            circle1.y = (int)numericUpDown4.Value;
            circle1.radius = (int)numericUpDown5.Value;
            double distance = Math.Sqrt(Math.Pow(point1.x - circle1.x, 2) + Math.Pow(point1.y - circle1.y, 2));
            if (distance <= circle1.radius)
            {

                MessageBox.Show("Collision has occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                control = 1;
            }
            else
            {

                MessageBox.Show("Collision has not occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                control = 0;
            }



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            noktaCember();
            button2.Enabled = true;

        }

        private void nokta_cember_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            draw_point_circle draw_Point_Circle = new draw_point_circle();
            draw_Point_Circle.x = control;
            this.Hide();
            draw_Point_Circle.Show();

        }
    }
    public class _Point
    {
        public int x;
        public int y;
    }
    class Circle
    {
        public int x;
        public int y;
        public int radius;
    }

}
