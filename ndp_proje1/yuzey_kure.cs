using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnityEngine;

namespace ndp_proje1
{
    public partial class yuzey_kure : Form
    {
        public int control = 0;
        Sphere sphere1 = new Sphere();
        Surface surface1 = new Surface();
        public yuzey_kure()
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
        public void yuzeyKure()
        {
            sphere1.x = (int)numericUpDown1.Value;
            sphere1.y = (int)numericUpDown2.Value;
            sphere1.z = (int)numericUpDown3.Value;
            sphere1.radius = (int)numericUpDown4.Value;

            surface1.x = (int)numericUpDown5.Value;
            surface1.y = (int)numericUpDown6.Value;
            surface1.z = (int)numericUpDown7.Value;

            Vector3 surfaceNormal = new Vector3(surface1.x, surface1.y, surface1.z) - new Vector3(0, 0, 0);

            // Küre merkezi ile yüzey arasındaki mesafeyi hesapla
            float distance = Vector3.Dot(surfaceNormal, new Vector3(sphere1.x, sphere1.y, sphere1.z)) / Math.Sqrt(surfaceNormal.x * surfaceNormal.x + surfaceNormal.y * surfaceNormal.y + surfaceNormal.z * surfaceNormal.z);

        }
        class Sphere
        {
            public int x;
            public int y;
            public int z;
            public int radius;

        }
        class Surface
        {
            public int x;
            public int y;
            public int z;

        }
    }

}
