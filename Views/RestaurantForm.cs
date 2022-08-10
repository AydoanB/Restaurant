using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ConsoleApp1;
using RestaurantManager;
using RestaurantManager.Services;

namespace WindowsFormsApp1
{
    public partial class RestaurantForm : Form
    {
        private readonly IEnumerable<IDish> dishes;
        private readonly RestaurantService restaurantService;
        
        private readonly ReceiptService receiptService;

        public RestaurantForm(IEnumerable<IDish> Dishes)
        {
            this.dishes = Dishes;
            this.restaurantService = new RestaurantService();
            this.receiptService = new ReceiptService();
            
            InitializeComponent();

            foreach (var dish in Dishes)
            {
                checkedListBox1.Items.Add(dish);
            }

        }

        private void button1_FinishOrder_Click(object sender, EventArgs e)
        {
            int tableNumber = int.Parse(comboBox2_Tables.Text);

            comboBox2_Tables.Text = "Изберете маса";

            this.UncheckSelectedDishes();

            var selectedDishes = checkedListBox1.SelectedItems.Cast<IDish>().ToList();

            var table = restaurantService.MakeOrder(tableNumber, selectedDishes);

            MarkTableAsOccupied(table);

            //restaurantController.AddDishToTheTable(SelectedDishes(), tableNumber);
            //if (!comboBox1_OccupiedTables.Items.Contains(t.TableNumber))
            //{
            //comboBox1_OccupiedTables.Items.Add(t.TableNumber);
            //}
        }

        private void button1_FInishTable_Click(object sender, EventArgs e)
        {

            var tableNumber = int.Parse(comboBox1_OccupiedTables.Text);
            
            var table = restaurantService.GetByTableNumber(tableNumber);

            //receiptService.ShowReceipt(tableNumber, table);
            
            Receipt receipt = new Receipt(table);
            
            receipt.ShowDialog();

            // decimal sumForSpecifiedTable = Restaurant.Tables.FirstOrDefault(n => n.TableNumber == selection).Check;

            //Receipt receipt = new Receipt(dishesOnTableForReceipt, sumForSpecifiedTable, caloriesForSpecifiedTable);
            // receipt.ShowDialog();
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

        private void MarkTableAsOccupied(int tableNumber)
        {
            this.comboBox1_OccupiedTables.Items.Add(tableNumber);
        }

    }
}
