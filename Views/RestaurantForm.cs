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
using Menu = ConsoleApp1.Menu;

namespace WindowsFormsApp1
{
    public partial class RestaurantForm : Form
    {
        Restaurant restaurant = new Restaurant();
        private Table t = null;
        public RestaurantForm(List<IDish> DishesFromMenuWindow)
        {
            InitializeComponent();
            
            foreach (var dish in DishesFromMenuWindow)
            {
                checkedListBox1.Items.Add(dish);
            }
            
        }

        private void button1_FinishOrder_Click(object sender, EventArgs e)
        {
            t = new Table(int.Parse(comboBox2_Tables.Text));

            comboBox2_Tables.Text = "Изберете маса";

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                CheckState s = checkedListBox1.GetItemCheckState(i);

                if (s == CheckState.Checked)
                {
                    restaurant.AddTable(t, (IDish)checkedListBox1.Items[i]);
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            if (!comboBox1_OccupiedTables.Items.Contains(t.TableNumber))
            {
                comboBox1_OccupiedTables.Items.Add(t.TableNumber);
            }
        }

        private void button1_FInishTable_Click(object sender, EventArgs e)
        {
         

            var selection = int.Parse(comboBox1_OccupiedTables.Text);
            decimal sumForSpecifiedTable = restaurant.DishesOnSpecifiedTable(selection).Sum(x => x.Price);
            double caloriesForSpecifiedTable = restaurant.DishesOnSpecifiedTable(selection).Sum(x => x.Calories);

            Receipt receipt = new Receipt(restaurant.DishesOnSpecifiedTable(selection), sumForSpecifiedTable, caloriesForSpecifiedTable);
            receipt.ShowDialog();
        }

       
    }
}
