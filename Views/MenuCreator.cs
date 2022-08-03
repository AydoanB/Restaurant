using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ConsoleApp1;
using WindowsFormsApp1.Controller;
using Menu = ConsoleApp1.Menu;

namespace WindowsFormsApp1
{
    public partial class MenuCreator : Form
    {
        private readonly MenuController menuController;

        public MenuCreator()
        {
            InitializeComponent();
            this.menuController = new MenuController();
        }


        private void button_Add_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text.Trim();
            string category = textBox_Category.Text.Trim();
            decimal price = decimal.Parse(textBox_Price.Text.Trim());
            double weight = double.Parse(textBox_Weight.Text.Trim());


            IDish dish = menuController.AddDishToTheMenu(category, name, weight, price);

            listBox1.Items.Add(dish.ToString());

            textBox_Name.Text = "";
            textBox_Category.Text = "";
            textBox_Price.Text = "";
            textBox_Weight.Text = "";
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            RestaurantForm rs = new RestaurantForm();
            rs.ShowDialog();
        }

       
    }
}
