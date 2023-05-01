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


    public partial class nokta_dortgen : Form
    {
        public int control = 0;
        Rectangle rectangle1 = new Rectangle();
        _Point point1 = new _Point();


        public nokta_dortgen()
        {
            InitializeComponent();

        }

        private void nokta_dortgen_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            noktaDortgen();

            button2.Enabled = true;


        }

        public void noktaDortgen()
        {
            point1.x = (int)numericUpDown1.Value;
            point1.y = (int)numericUpDown2.Value;

            rectangle1.x = (int)numericUpDown3.Value;
            rectangle1.y = (int)numericUpDown4.Value;
            rectangle1.height = (int)numericUpDown5.Value;
            rectangle1.width = (int)numericUpDown6.Value;



            if ((rectangle1.x <= point1.x && ((rectangle1.x + rectangle1.width) >= point1.x)) && (rectangle1.y >= point1.y && point1.y >= (rectangle1.y - rectangle1.height)))
            {
                MessageBox.Show("Collision has occurred!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);

                control = 1;

            }
            else
            {
                MessageBox.Show("Collision has not  occurred!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                control = 0;
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            draw_point_rect draw_Point_Rect = new draw_point_rect();
            draw_Point_Rect.x = control;
            this.Hide();
            draw_Point_Rect.Show();


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




