using DriversManagerProject.CarFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriversManagerProject
{
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
        }

        public void PopulateForm()
        {
            cboDrivers.DataSource = MyApplication.allDrivers.Values ;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //String license 
           // add car Car car = new Car();
           // 
           // add this class to the list of Cars

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =  colorDialog1.ShowDialog();
            
        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
