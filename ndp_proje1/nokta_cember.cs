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
        _Point point1 = new _Point();
        Circle circle1 = new Circle();
        public nokta_cember()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            point1.x = (int)numericUpDown1.Value;
            point1.y = (int)numericUpDown2.Value;

            circle1.x = (int)numericUpDown3.Value;
            circle1.y = (int)numericUpDown4.Value;
            circle1.radius = (int)numericUpDown5.Value;
           
            noktaCember();
        }
        public void noktaCember()
        {
            double distance = Math.Sqrt(Math.Pow(point1.x - circle1.x, 2) + Math.Pow(point1.y - circle1.y, 2));
            if (distance <= circle1.radius)
            {

                MessageBox.Show("Collision has occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Collision has not occured!", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



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
