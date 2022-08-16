using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ConsoleApp1;
using RestaurantManager.Controller;
using RestaurantManager.Services;
using WindowsFormsApp1;

namespace RestaurantManager
{

    public partial class MenuCreator : Form
    {
        private readonly MenuService menuService;

        public MenuCreator()
        {
            InitializeComponent();

            this.menuService = new MenuService();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text.Trim();
            string category = textBox_Category.Text.Trim();
            decimal price = decimal.Parse(textBox_Price.Text.Trim());
            double weight = double.Parse(textBox_Weight.Text.Trim());

            var model = new DishInputModel()
            {
                Name = name,
                Category = category,
                Price = price,
                Weight = weight,
            };

            menuService.CreateDish(model);

            listBox1.Items.Add(menuService.GetForMenuList());

            ClearInputs();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            RestaurantForm rs = new RestaurantForm(menuService.GetAll());
            rs.ShowDialog();
        }

        private void ClearInputs()
        {
            textBox_Name.Clear();
            textBox_Category.Clear();
            textBox_Price.Clear();
            textBox_Weight.Clear();
        }

        
    }
}
