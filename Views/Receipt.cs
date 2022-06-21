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

namespace WindowsFormsApp1
{
    public partial class Receipt : Form
    {
        private List<IDish> dishesForReceipt;
        public Receipt(List<IDish> dishesOnTable, decimal sum,double calories)
        {
            InitializeComponent();
            dishesForReceipt = new List<IDish>();

            foreach (var dish in dishesOnTable)
            {
                listBox1_OrderedFoodsPerTable.Items.Add(dish.ToString());
            }

            textBox2_TotalSum.Text = $"{sum} лв.";
            textBox2_Calories.Text = $"{calories} kcal";

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
