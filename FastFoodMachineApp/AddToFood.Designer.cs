namespace FastFoodMachineApp
{
    partial class AddToFood
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
            this.Cheese = new System.Windows.Forms.CheckBox();
            this.Ham = new System.Windows.Forms.CheckBox();
            this.Jam = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Cheese
            // 
            this.Cheese.AutoSize = true;
            this.Cheese.Location = new System.Drawing.Point(48, 100);
            this.Cheese.Name = "Cheese";
            this.Cheese.Size = new System.Drawing.Size(96, 19);
            this.Cheese.TabIndex = 0;
            this.Cheese.Text = "Сыр - 10 руб";
            this.Cheese.UseVisualStyleBackColor = true;
            this.Cheese.CheckedChanged += new System.EventHandler(this.Cheese_CheckedChanged);
            // 
            // Ham
            // 
            this.Ham.AutoSize = true;
            this.Ham.Location = new System.Drawing.Point(48, 138);
            this.Ham.Name = "Ham";
            this.Ham.Size = new System.Drawing.Size(117, 19);
            this.Ham.TabIndex = 1;
            this.Ham.Text = "Ветчина - 20 руб";
            this.Ham.UseVisualStyleBackColor = true;
            this.Ham.CheckedChanged += new System.EventHandler(this.Ham_CheckedChanged);
            // 
            // Jam
            // 
            this.Jam.AutoSize = true;
            this.Jam.Location = new System.Drawing.Point(47, 58);
            this.Jam.Name = "Jam";
            this.Jam.Size = new System.Drawing.Size(104, 19);
            this.Jam.TabIndex = 2;
            this.Jam.Text = "Джем - 15 руб";
            this.Jam.UseVisualStyleBackColor = true;
            this.Jam.CheckedChanged += new System.EventHandler(this.Jam_CheckedChanged);
            // 
            // AddToFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.Jam);
            this.Controls.Add(this.Ham);
            this.Controls.Add(this.Cheese);
            this.Name = "AddToFood";
            this.Text = "Добавка к обеду";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox Cheese;
        private CheckBox Ham;
        private CheckBox Jam;
    }
}