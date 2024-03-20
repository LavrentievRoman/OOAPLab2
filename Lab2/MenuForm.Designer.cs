namespace Lab2
{
    partial class MenuForm
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
            this.bavarianPizzaButton = new System.Windows.Forms.Button();
            this.cheezePizzaButton = new System.Windows.Forms.Button();
            this.PepperoniPizzaButton = new System.Windows.Forms.Button();
            this.meatPizzaButton = new System.Windows.Forms.Button();
            this.PizzaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bavarianPizzaButton
            // 
            this.bavarianPizzaButton.Location = new System.Drawing.Point(23, 37);
            this.bavarianPizzaButton.Name = "bavarianPizzaButton";
            this.bavarianPizzaButton.Size = new System.Drawing.Size(75, 23);
            this.bavarianPizzaButton.TabIndex = 0;
            this.bavarianPizzaButton.Text = "Баварская ";
            this.bavarianPizzaButton.UseVisualStyleBackColor = true;
            this.bavarianPizzaButton.Click += new System.EventHandler(this.bavarianPizzaButton_Click);
            // 
            // cheezePizzaButton
            // 
            this.cheezePizzaButton.Location = new System.Drawing.Point(126, 37);
            this.cheezePizzaButton.Name = "cheezePizzaButton";
            this.cheezePizzaButton.Size = new System.Drawing.Size(75, 23);
            this.cheezePizzaButton.TabIndex = 1;
            this.cheezePizzaButton.Text = "Сырная";
            this.cheezePizzaButton.UseVisualStyleBackColor = true;
            this.cheezePizzaButton.Click += new System.EventHandler(this.cheezePizzaButton_Click);
            // 
            // PepperoniPizzaButton
            // 
            this.PepperoniPizzaButton.Location = new System.Drawing.Point(23, 66);
            this.PepperoniPizzaButton.Name = "PepperoniPizzaButton";
            this.PepperoniPizzaButton.Size = new System.Drawing.Size(75, 23);
            this.PepperoniPizzaButton.TabIndex = 2;
            this.PepperoniPizzaButton.Text = "Пепперони";
            this.PepperoniPizzaButton.UseVisualStyleBackColor = true;
            this.PepperoniPizzaButton.Click += new System.EventHandler(this.PepperoniPizzaButton_Click);
            // 
            // meatPizzaButton
            // 
            this.meatPizzaButton.Location = new System.Drawing.Point(126, 66);
            this.meatPizzaButton.Name = "meatPizzaButton";
            this.meatPizzaButton.Size = new System.Drawing.Size(75, 23);
            this.meatPizzaButton.TabIndex = 3;
            this.meatPizzaButton.Text = "Мясная";
            this.meatPizzaButton.UseVisualStyleBackColor = true;
            this.meatPizzaButton.Click += new System.EventHandler(this.meatPizzaButton_Click);
            // 
            // PizzaLabel
            // 
            this.PizzaLabel.AutoSize = true;
            this.PizzaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PizzaLabel.Location = new System.Drawing.Point(51, 9);
            this.PizzaLabel.Name = "PizzaLabel";
            this.PizzaLabel.Size = new System.Drawing.Size(115, 16);
            this.PizzaLabel.TabIndex = 4;
            this.PizzaLabel.Text = "Выбирете пиццу";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 101);
            this.Controls.Add(this.PizzaLabel);
            this.Controls.Add(this.meatPizzaButton);
            this.Controls.Add(this.PepperoniPizzaButton);
            this.Controls.Add(this.cheezePizzaButton);
            this.Controls.Add(this.bavarianPizzaButton);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bavarianPizzaButton;
        private System.Windows.Forms.Button cheezePizzaButton;
        private System.Windows.Forms.Button PepperoniPizzaButton;
        private System.Windows.Forms.Button meatPizzaButton;
        private System.Windows.Forms.Label PizzaLabel;
    }
}