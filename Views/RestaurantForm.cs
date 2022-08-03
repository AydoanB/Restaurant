using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;
using WindowsFormsApp1.Controller;
using Menu = ConsoleApp1.Menu;

namespace WindowsFormsApp1
{
    public partial class RestaurantForm : Form
    {
        //Restaurant restaurant = new Restaurant();
        private RestaurantController restaurantController;
        private Table t = null;
        public RestaurantForm()
        {
            InitializeComponent();

            foreach (var dish in ConsoleApp1.Menu.Dishes)
            {
                checkedListBox1.Items.Add(dish);
            }

        }

        private void button1_FinishOrder_Click(object sender, EventArgs e)
        {
            int tableNumber = int.Parse(comboBox2_Tables.Text);

            comboBox2_Tables.Text = "Изберете маса";

            this.UncheckSelectedDishes();

            restaurantController.AddDishToTheTable(SelectedDishes(), tableNumber);

            if (!comboBox1_OccupiedTables.Items.Contains(t.TableNumber))
            {
                comboBox1_OccupiedTables.Items.Add(t.TableNumber);
            }
        }

        private void button1_FInishTable_Click(object sender, EventArgs e)
        {

            var selection = int.Parse(comboBox1_OccupiedTables.Text);

            decimal sumForSpecifiedTable = Restaurant.Tables.FirstOrDefault(n => n.TableNumber == selection).Check;
            double caloriesForSpecifiedTable = Restaurant.Tables.FirstOrDefault(n => n.TableNumber == selection).Calories;
            List<IDish> dishesOnTableForReceipt =
                Restaurant.Tables.FirstOrDefault(x => x.TableNumber == selection).DishesOnTable;

            Receipt receipt = new Receipt(dishesOnTableForReceipt, sumForSpecifiedTable, caloriesForSpecifiedTable);
            receipt.ShowDialog();
        }

        private void UncheckSelectedDishes()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                CheckState s = checkedListBox1.GetItemCheckState(i);

                if (s == CheckState.Checked)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private List<IDish> SelectedDishes()
        {
            List<IDish> dishes = checkedListBox1.CheckedItems.Cast<IDish>().ToList();
            return dishes;
        }

    }
}
