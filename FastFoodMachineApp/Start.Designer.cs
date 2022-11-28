namespace FastFoodMachineApp
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChoiceFood = new System.Windows.Forms.Button();
            this.ChoiceDrinks = new System.Windows.Forms.Button();
            this.CancelOrder = new System.Windows.Forms.Button();
            this.ToOrder = new System.Windows.Forms.Button();
            this.GetCost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChoiceFood
            // 
            this.ChoiceFood.Location = new System.Drawing.Point(80, 54);
            this.ChoiceFood.Name = "ChoiceFood";
            this.ChoiceFood.Size = new System.Drawing.Size(150, 100);
            this.ChoiceFood.TabIndex = 0;
            this.ChoiceFood.Text = "Выбрать еду";
            this.ChoiceFood.UseVisualStyleBackColor = true;
            this.ChoiceFood.Click += new System.EventHandler(this.ChoiceFood_Click);
            // 
            // ChoiceDrinks
            // 
            this.ChoiceDrinks.Location = new System.Drawing.Point(350, 54);
            this.ChoiceDrinks.Name = "ChoiceDrinks";
            this.ChoiceDrinks.Size = new System.Drawing.Size(150, 100);
            this.ChoiceDrinks.TabIndex = 1;
            this.ChoiceDrinks.Text = "Выбрать напитки";
            this.ChoiceDrinks.UseVisualStyleBackColor = true;
            this.ChoiceDrinks.Click += new System.EventHandler(this.ChoiceDrinks_Click);
            // 
            // CancelOrder
            // 
            this.CancelOrder.Location = new System.Drawing.Point(80, 216);
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Size = new System.Drawing.Size(150, 100);
            this.CancelOrder.TabIndex = 2;
            this.CancelOrder.Text = "Отменить заказ";
            this.CancelOrder.UseVisualStyleBackColor = true;
            this.CancelOrder.Click += new System.EventHandler(this.CancelOrder_Click);
            // 
            // ToOrder
            // 
            this.ToOrder.Location = new System.Drawing.Point(223, 366);
            this.ToOrder.Name = "ToOrder";
            this.ToOrder.Size = new System.Drawing.Size(150, 68);
            this.ToOrder.TabIndex = 3;
            this.ToOrder.Text = "Сделать заказ";
            this.ToOrder.UseVisualStyleBackColor = true;
            this.ToOrder.Click += new System.EventHandler(this.ToOrder_Click);
            // 
            // GetCost
            // 
            this.GetCost.Location = new System.Drawing.Point(350, 216);
            this.GetCost.Name = "GetCost";
            this.GetCost.Size = new System.Drawing.Size(150, 108);
            this.GetCost.TabIndex = 4;
            this.GetCost.Text = "Узнать стоимость заказа";
            this.GetCost.UseVisualStyleBackColor = true;
            this.GetCost.Click += new System.EventHandler(this.GetCost_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.GetCost);
            this.Controls.Add(this.ToOrder);
            this.Controls.Add(this.CancelOrder);
            this.Controls.Add(this.ChoiceDrinks);
            this.Controls.Add(this.ChoiceFood);
            this.Name = "Start";
            this.Text = "FastFoodMachine";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button ChoiceFood;
        private Button ChoiceDrinks;
        private Button CancelOrder;
        private Button ToOrder;
        private Button GetCost;
    }
}