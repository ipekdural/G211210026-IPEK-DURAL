using System.Windows.Forms;
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

            string[] items = new string[] { "Point-Rectangle", "Point-Circle", "Rectangle-Rectangle", "Rectangle-Circle", "Circle-Circle", "Point-Sphere", "Point-Rectangular Prism", "Point-Cylinder", "Cylinder-Cylinder", "Sphere-Sphere", "Sphere-Cylinder", "Surface-Sphere", "Surface-Rectangular Prism", "Surface-Cylinder", "Sphere-Rectangular Prism", "Rectangular Prism-Rectangular Prism" };
            comboBox1.Items.AddRange(items);


        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Point-Rectangle")
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
            if(comboBox1.Text == "Rectangle-Rectangle")
            {
                dikdortgen_dikdortgen dikdortgen_Dikdortgen = new dikdortgen_dikdortgen();
                dikdortgen_Dikdortgen.Show();
                this.Hide();
            }
            if(comboBox1.Text == "Rectangle-Circle")
            {
                dikdortgen_cember dikdortgen_Cember=new dikdortgen_cember();
                dikdortgen_Cember.Show();
                this.Hide();
            }
            if(comboBox1.Text == "Circle-Circle")
            {
                cember_cember cember_Cember= new cember_cember();
                cember_Cember.Show();
                this.Hide();

            }
        }

        
    }
}
