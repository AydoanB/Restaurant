
namespace WindowsFormsApp1
{
    partial class RestaurantForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2_Tables = new System.Windows.Forms.ComboBox();
            this.button1_FinishOrder = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1_FInishTable = new System.Windows.Forms.Button();
            this.comboBox1_OccupiedTables = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поръчки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Храни";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Маса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(808, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // comboBox2_Tables
            // 
            this.comboBox2_Tables.FormattingEnabled = true;
            this.comboBox2_Tables.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox2_Tables.Location = new System.Drawing.Point(186, 309);
            this.comboBox2_Tables.Name = "comboBox2_Tables";
            this.comboBox2_Tables.Size = new System.Drawing.Size(177, 24);
            this.comboBox2_Tables.TabIndex = 5;
            this.comboBox2_Tables.Text = "Избор на маса";
            // 
            // button1_FinishOrder
            // 
            this.button1_FinishOrder.Location = new System.Drawing.Point(12, 398);
            this.button1_FinishOrder.Name = "button1_FinishOrder";
            this.button1_FinishOrder.Size = new System.Drawing.Size(157, 58);
            this.button1_FinishOrder.TabIndex = 6;
            this.button1_FinishOrder.Text = "Направи поръчка";
            this.button1_FinishOrder.UseVisualStyleBackColor = true;
            this.button1_FinishOrder.Click += new System.EventHandler(this.button1_FinishOrder_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(166, 138);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(215, 123);
            this.checkedListBox1.TabIndex = 8;
            // 
            // button1_FInishTable
            // 
            this.button1_FInishTable.Location = new System.Drawing.Point(384, 398);
            this.button1_FInishTable.Name = "button1_FInishTable";
            this.button1_FInishTable.Size = new System.Drawing.Size(157, 58);
            this.button1_FInishTable.TabIndex = 9;
            this.button1_FInishTable.Text = "Приключи маса";
            this.button1_FInishTable.UseVisualStyleBackColor = true;
            this.button1_FInishTable.Click += new System.EventHandler(this.button1_FInishTable_Click);
            // 
            // comboBox1_OccupiedTables
            // 
            this.comboBox1_OccupiedTables.FormattingEnabled = true;
            this.comboBox1_OccupiedTables.Location = new System.Drawing.Point(348, 368);
            this.comboBox1_OccupiedTables.Name = "comboBox1_OccupiedTables";
            this.comboBox1_OccupiedTables.Size = new System.Drawing.Size(193, 24);
            this.comboBox1_OccupiedTables.TabIndex = 10;
            this.comboBox1_OccupiedTables.Text = "Избор на маса за сметка";
            // 
            // RestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 468);
            this.Controls.Add(this.comboBox1_OccupiedTables);
            this.Controls.Add(this.button1_FInishTable);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1_FinishOrder);
            this.Controls.Add(this.comboBox2_Tables);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RestaurantForm";
            this.Text = "RestaurantForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2_Tables;
        private System.Windows.Forms.Button button1_FinishOrder;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1_FInishTable;
        private System.Windows.Forms.ComboBox comboBox1_OccupiedTables;
    }
}