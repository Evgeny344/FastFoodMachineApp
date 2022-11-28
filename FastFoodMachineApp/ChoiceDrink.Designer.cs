namespace FastFoodMachineApp
{
    partial class ChoiceDrink
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
            this.Latte = new System.Windows.Forms.CheckBox();
            this.BlackTea = new System.Windows.Forms.CheckBox();
            this.GreenTea = new System.Windows.Forms.CheckBox();
            this.Cappuccino = new System.Windows.Forms.CheckBox();
            this.Espresso = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Latte
            // 
            this.Latte.AutoSize = true;
            this.Latte.Location = new System.Drawing.Point(39, 44);
            this.Latte.Name = "Latte";
            this.Latte.Size = new System.Drawing.Size(108, 19);
            this.Latte.TabIndex = 0;
            this.Latte.Text = "Латте - 180 руб";
            this.Latte.UseVisualStyleBackColor = true;
            this.Latte.CheckedChanged += new System.EventHandler(this.Latte_CheckedChanged);
            // 
            // BlackTea
            // 
            this.BlackTea.AutoSize = true;
            this.BlackTea.Location = new System.Drawing.Point(39, 160);
            this.BlackTea.Name = "BlackTea";
            this.BlackTea.Size = new System.Drawing.Size(139, 19);
            this.BlackTea.TabIndex = 1;
            this.BlackTea.Text = "Чёрный чай - 40 руб";
            this.BlackTea.UseVisualStyleBackColor = true;
            this.BlackTea.CheckedChanged += new System.EventHandler(this.BlackTea_CheckedChanged);
            // 
            // GreenTea
            // 
            this.GreenTea.AutoSize = true;
            this.GreenTea.Location = new System.Drawing.Point(39, 197);
            this.GreenTea.Name = "GreenTea";
            this.GreenTea.Size = new System.Drawing.Size(144, 19);
            this.GreenTea.TabIndex = 2;
            this.GreenTea.Text = "Зелёный чай - 40 руб";
            this.GreenTea.UseVisualStyleBackColor = true;
            this.GreenTea.CheckedChanged += new System.EventHandler(this.GreenTea_CheckedChanged);
            // 
            // Cappuccino
            // 
            this.Cappuccino.AutoSize = true;
            this.Cappuccino.Location = new System.Drawing.Point(39, 82);
            this.Cappuccino.Name = "Cappuccino";
            this.Cappuccino.Size = new System.Drawing.Size(132, 19);
            this.Cappuccino.TabIndex = 3;
            this.Cappuccino.Text = "Капучино - 190 руб";
            this.Cappuccino.UseVisualStyleBackColor = true;
            this.Cappuccino.CheckedChanged += new System.EventHandler(this.Cappuccino_CheckedChanged);
            // 
            // Espresso
            // 
            this.Espresso.AutoSize = true;
            this.Espresso.Location = new System.Drawing.Point(39, 121);
            this.Espresso.Name = "Espresso";
            this.Espresso.Size = new System.Drawing.Size(130, 19);
            this.Espresso.TabIndex = 4;
            this.Espresso.Text = "Эспрессо - 150 руб";
            this.Espresso.UseVisualStyleBackColor = true;
            this.Espresso.CheckedChanged += new System.EventHandler(this.Espresso_CheckedChanged);
            // 
            // ChoiceDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.Espresso);
            this.Controls.Add(this.Cappuccino);
            this.Controls.Add(this.GreenTea);
            this.Controls.Add(this.BlackTea);
            this.Controls.Add(this.Latte);
            this.Name = "ChoiceDrink";
            this.Text = "Выбор напитков";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox Latte;
        private CheckBox BlackTea;
        private CheckBox GreenTea;
        private CheckBox Cappuccino;
        private CheckBox Espresso;
    }
}