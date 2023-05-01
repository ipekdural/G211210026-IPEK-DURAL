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
    public partial class dikdortgen_dikdortgen : Form
    {
        public int control = 0;
        Rectangle rectangle1 = new Rectangle();
        Rectangle rectangle2 = new Rectangle();

        public dikdortgen_dikdortgen()
        {

            InitializeComponent();
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
        public void dikdortgenDikdortgen()
        {

            rectangle1.x = (int)numericUpDown1.Value;
            rectangle1.y = (int)numericUpDown2.Value;
            rectangle1.height = (int)numericUpDown3.Value;
            rectangle1.width = (int)numericUpDown4.Value;

            rectangle2.x = (int)numericUpDown5.Value;
            rectangle2.y = (int)numericUpDown6.Value;
            rectangle2.height = (int)numericUpDown7.Value;
            rectangle2.width = (int)numericUpDown8.Value;

            int left1 = rectangle1.x;
            int right1 = rectangle1.x + rectangle1.width;
            int top1 = rectangle1.y;
            int bottom1 = rectangle1.y + rectangle1.y;

            int left2 = rectangle2.x;
            int right2 = rectangle2.x + rectangle2.width;
            int top2 = rectangle2.y;
            int bottom2 = rectangle2.y + rectangle2.height;

            if (left1 <= right2 && right1 >= left2 && top1 <= bottom2 && bottom1 >= top2)
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

        private void button1_Click(object sender, EventArgs e)
        {
            dikdortgenDikdortgen();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            draw_rect_rect draw_Rect_Rect = new draw_rect_rect();
            draw_Rect_Rect.x = control;
            this.Hide();
            draw_Rect_Rect.Show();
        }
    }
    public class Rectangle
    {
        public int x;
        public int y;
        public int width;
        public int height;
    }
}
