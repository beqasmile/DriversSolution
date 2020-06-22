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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Driver form2 = new Driver();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FleerOfCar fleerOfCar = new FleerOfCar();
            fleerOfCar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            MyApplication.CreateSomeCars();
            MyApplication.CreateSomeDrivers();
        }
    }
}
