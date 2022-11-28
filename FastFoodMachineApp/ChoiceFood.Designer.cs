namespace FastFoodMachineApp
{
    partial class ChoiceFood
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
            this.Bread = new System.Windows.Forms.CheckBox();
            this.Sandwich = new System.Windows.Forms.CheckBox();
            this.Bun = new System.Windows.Forms.CheckBox();
            this.Lunch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Bread
            // 
            this.Bread.AutoSize = true;
            this.Bread.Location = new System.Drawing.Point(49, 47);
            this.Bread.Name = "Bread";
            this.Bread.Size = new System.Drawing.Size(99, 19);
            this.Bread.TabIndex = 0;
            this.Bread.Text = "Хлеб - 10 руб";
            this.Bread.UseVisualStyleBackColor = true;
            this.Bread.CheckedChanged += new System.EventHandler(this.Bread_CheckedChanged);
            // 
            // Sandwich
            // 
            this.Sandwich.AutoSize = true;
            this.Sandwich.Location = new System.Drawing.Point(49, 141);
            this.Sandwich.Name = "Sandwich";
            this.Sandwich.Size = new System.Drawing.Size(261, 19);
            this.Sandwich.TabIndex = 1;
            this.Sandwich.Text = "Бутерброд (хлеб + ветчина + сыр) - 40 руб";
            this.Sandwich.UseVisualStyleBackColor = true;
            this.Sandwich.CheckedChanged += new System.EventHandler(this.Sandwich_CheckedChanged);
            // 
            // Bun
            // 
            this.Bun.AutoSize = true;
            this.Bun.Location = new System.Drawing.Point(49, 94);
            this.Bun.Name = "Bun";
            this.Bun.Size = new System.Drawing.Size(121, 19);
            this.Bun.TabIndex = 2;
            this.Bun.Text = "Булочка -  20 руб";
            this.Bun.UseVisualStyleBackColor = true;
            this.Bun.CheckedChanged += new System.EventHandler(this.Bun_CheckedChanged);
            // 
            // Lunch
            // 
            this.Lunch.AutoSize = true;
            this.Lunch.Location = new System.Drawing.Point(49, 188);
            this.Lunch.Name = "Lunch";
            this.Lunch.Size = new System.Drawing.Size(396, 19);
            this.Lunch.TabIndex = 3;
            this.Lunch.Text = "Комплексный обед (бутерброд, чёрный чай,  сахар, джем) - 85 руб";
            this.Lunch.UseVisualStyleBackColor = true;
            this.Lunch.CheckedChanged += new System.EventHandler(this.Lunch_CheckedChanged);
            // 
            // ChoiceFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.Lunch);
            this.Controls.Add(this.Bun);
            this.Controls.Add(this.Sandwich);
            this.Controls.Add(this.Bread);
            this.Name = "ChoiceFood";
            this.Text = "Меню на обед";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox Bread;
        private CheckBox Sandwich;
        private CheckBox Bun;
        private CheckBox Lunch;
    }
}