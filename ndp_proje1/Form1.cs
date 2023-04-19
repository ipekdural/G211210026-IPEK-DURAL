using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ndp_proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] items = new string[] { "Point-Quadrilateral", "Point-Circle", "Rectangle-Rectangle", "Rectangle-Circle", "Circle-Circle", "Point-Sphere", "Point-Rectangular Prism", "Point-Cylinder", "Cylinder-Cylinder", "Sphere-Sphere", "Sphere-Cylinder", "Surface-Sphere", "Surface-Rectangular Prism", "Surface-Cylinder", "Sphere-Rectangular Prism", "Rectangular Prism-Rectangular Prism" };
            comboBox1.Items.AddRange(items);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Point-Quadrilateral")
            {
                nokta_dortgen nokta_Dortgen = new nokta_dortgen();
                nokta_Dortgen.Show();
                this.Hide();

            }
            if (comboBox1.Text == "Point-Circle")
            {
              nokta_cember nokta_Cember = new nokta_cember();
               nokta_Cember.Show();
                this.Hide();

            }
        }
    }
}
