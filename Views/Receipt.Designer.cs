
namespace WindowsFormsApp1
{
    partial class Receipt
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
            this.listBox1_OrderedFoodsPerTable = new System.Windows.Forms.ListBox();
            this.textBox2_TotalSum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2_Calories = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Касов бон";
            // 
            // listBox1_OrderedFoodsPerTable
            // 
            this.listBox1_OrderedFoodsPerTable.FormattingEnabled = true;
            this.listBox1_OrderedFoodsPerTable.ItemHeight = 16;
            this.listBox1_OrderedFoodsPerTable.Location = new System.Drawing.Point(-2, 125);
            this.listBox1_OrderedFoodsPerTable.Name = "listBox1_OrderedFoodsPerTable";
            this.listBox1_OrderedFoodsPerTable.Size = new System.Drawing.Size(379, 356);
            this.listBox1_OrderedFoodsPerTable.TabIndex = 3;
            // 
            // textBox2_TotalSum
            // 
            this.textBox2_TotalSum.Location = new System.Drawing.Point(265, 487);
            this.textBox2_TotalSum.Name = "textBox2_TotalSum";
            this.textBox2_TotalSum.Size = new System.Drawing.Size(100, 22);
            this.textBox2_TotalSum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вашата сметка е:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Изход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 59);
            this.button2.TabIndex = 8;
            this.button2.Text = "Обратно към поръчки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2_Calories
            // 
            this.textBox2_Calories.Location = new System.Drawing.Point(265, 531);
            this.textBox2_Calories.Name = "textBox2_Calories";
            this.textBox2_Calories.Size = new System.Drawing.Size(100, 22);
            this.textBox2_Calories.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Погълнати калории:";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 627);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2_Calories);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2_TotalSum);
            this.Controls.Add(this.listBox1_OrderedFoodsPerTable);
            this.Controls.Add(this.label1);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1_OrderedFoodsPerTable;
        private System.Windows.Forms.TextBox textBox2_TotalSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2_Calories;
        private System.Windows.Forms.Label label2;
    }
}