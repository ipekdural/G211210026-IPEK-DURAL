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
    public partial class dikdortgenler_prizması2 : Form
    {
        int control = 0;
        RectPrism rectPrism1 = new RectPrism();
        RectPrism rectPrism2 = new RectPrism();
        public dikdortgenler_prizması2()
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
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rectPrism22();
            button2.Enabled = true;
        }
        public void rectPrism22()
        {
            rectPrism1.x = (int)numericUpDown1.Value;
            rectPrism1.y = (int)numericUpDown2.Value;
            rectPrism1.z = (int)numericUpDown3.Value;
            rectPrism1.width = (int)numericUpDown4.Value;
            rectPrism1.height = (int)numericUpDown5.Value;
            rectPrism1.depth = (int)numericUpDown6.Value;

            rectPrism2.x = (int)numericUpDown7.Value;
            rectPrism2.y = (int)numericUpDown8.Value;
            rectPrism2.z = (int)numericUpDown9.Value;
            rectPrism2.width = (int)numericUpDown10.Value;
            rectPrism2.height = (int)numericUpDown11.Value;
            rectPrism2.depth = (int)numericUpDown12.Value;


            if (rectPrism1.x < rectPrism2.x + rectPrism2.width && rectPrism1.x + rectPrism1.width > rectPrism2.x && rectPrism1.y < rectPrism2.y + rectPrism2.height && rectPrism1.y + rectPrism1.height > rectPrism2.y && rectPrism1.z < rectPrism2.z + rectPrism2.depth && rectPrism1.z + rectPrism1.depth > rectPrism2.z)
            {
                MessageBox.Show("Collision has occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                control = 1;
            }
            else
            {
                MessageBox.Show("Collision has not occurred!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        class RectPrism
        {
            public int x;
            public int y;
            public int z;
            public int width;
            public int height;
            public int depth;

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            draw_2rectprism d = new draw_2rectprism();
            d.x = control;
            d.Show();
            this.Hide();
        }
    }
}
