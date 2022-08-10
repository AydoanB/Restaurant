using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;

namespace RestaurantManager
{
    public partial class Receipt : Form
    {
        public Receipt(Table table)
        {
            InitializeComponent();

            foreach (var dish in table.GetAll())
            {
                listBox1_OrderedFoodsPerTable.Items.Add(dish.ToString());
            }

            textBox2_TotalSum.Text = $"{table.Check} лв.";
            //textBox2_Calories.Text = $"{calories} kcal";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
