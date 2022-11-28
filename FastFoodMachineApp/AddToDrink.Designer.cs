namespace FastFoodMachineApp
{
    partial class AddToDrink
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
            this.Syrup = new System.Windows.Forms.CheckBox();
            this.Sugar = new System.Windows.Forms.CheckBox();
            this.Milk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Syrup
            // 
            this.Syrup.AutoSize = true;
            this.Syrup.Location = new System.Drawing.Point(40, 49);
            this.Syrup.Name = "Syrup";
            this.Syrup.Size = new System.Drawing.Size(108, 19);
            this.Syrup.TabIndex = 0;
            this.Syrup.Text = "Сироп - 20 руб";
            this.Syrup.UseVisualStyleBackColor = true;
            this.Syrup.CheckedChanged += new System.EventHandler(this.Syrup_CheckedChanged);
            // 
            // Sugar
            // 
            this.Sugar.AutoSize = true;
            this.Sugar.Location = new System.Drawing.Point(39, 85);
            this.Sugar.Name = "Sugar";
            this.Sugar.Size = new System.Drawing.Size(102, 19);
            this.Sugar.TabIndex = 1;
            this.Sugar.Text = "Сахар - 5 руб ";
            this.Sugar.UseVisualStyleBackColor = true;
            this.Sugar.CheckedChanged += new System.EventHandler(this.Sugar_CheckedChanged);
            // 
            // Milk
            // 
            this.Milk.AutoSize = true;
            this.Milk.Location = new System.Drawing.Point(39, 124);
            this.Milk.Name = "Milk";
            this.Milk.Size = new System.Drawing.Size(117, 19);
            this.Milk.TabIndex = 2;
            this.Milk.Text = "Молоко - 10 руб";
            this.Milk.UseVisualStyleBackColor = true;
            this.Milk.CheckedChanged += new System.EventHandler(this.Milk_CheckedChanged);
            // 
            // AddToDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.Milk);
            this.Controls.Add(this.Sugar);
            this.Controls.Add(this.Syrup);
            this.Name = "AddToDrink";
            this.Text = "Добавка к напитку";
            this.Load += new System.EventHandler(this.AddToDrink_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox Syrup;
        private CheckBox Sugar;
        private CheckBox Milk;
    }
}