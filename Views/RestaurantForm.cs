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

            var selectedDishes = GetAllSelectedDishes();

            this.UncheckSelectedDishes();

            var table = restaurantService.MakeOrder(tableNumber, selectedDishes);

            MarkTableAsOccupied(table);

        }

        private void button1_FInishTable_Click(object sender, EventArgs e)
        {
            var tableNumber = int.Parse(comboBox1_OccupiedTables.Text);

            var table = restaurantService.GetByTableNumber(tableNumber);

            Receipt receipt = new Receipt(table);

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

        private void MarkTableAsOccupied(int tableNumber)
        {
            if (!comboBox1_OccupiedTables.Items.Contains(tableNumber))
            {
                this.comboBox1_OccupiedTables.Items.Add(tableNumber);
            }
        }

        private List<IDish> GetAllSelectedDishes()
        {
            var selectedDishes = new List<IDish>();

            foreach (var dish in checkedListBox1.CheckedItems)
            {
                selectedDishes.Add((IDish)dish);
            }

            return selectedDishes;
        }

    }
}
