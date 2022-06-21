using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;
using Menu = ConsoleApp1.Menu;

namespace WindowsFormsApp1
{
    public partial class MenuCreator : Form
    {
        ConsoleApp1.Menu menu = new Menu();
        public MenuCreator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button_Add_Click(object sender, EventArgs e)
        {

            var name = textBox_Name.Text.Trim();
            var category = textBox_Category.Text.Trim();
            var price = decimal.Parse(textBox_Price.Text.Trim());
            var weight = double.Parse(textBox_Weight.Text.Trim());


            //Polymorphism
            IDish dish = null;
            
                if (category == "main")
                {
                    dish = new Main(name, weight, price);
                }
                else if (category == "drink")
                {
                    dish = new Drink(name, weight, price);
                }
                else if (category == "soup")
                {
                    dish = new Soup(name, weight, price);
                }
                else if (category == "salad")
                {
                    dish = new Salad(name, weight, price);
                }
                else if (category == "dessert")
                {
                    dish = new Dessert(name, weight, price);
                }
            menu.AddDish(dish);

            listBox1.Items.Add(dish.ToString());

            textBox_Name.Text = "";
            textBox_Category.Text = "";
            textBox_Price.Text = "";
            textBox_Weight.Text = "";


        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            RestaurantForm rs = new RestaurantForm(menu.Dishes);
            rs.ShowDialog();
        }

        
    }
}
