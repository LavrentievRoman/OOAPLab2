namespace Lab2
{
    partial class AdditiveForm
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
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.doughTypeComboBox = new System.Windows.Forms.ComboBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.doughTypeLabel = new System.Windows.Forms.Label();
            this.AdditiveLabel = new System.Windows.Forms.Label();
            this.mozzarellaCheckBox = new System.Windows.Forms.CheckBox();
            this.baconCheckBox = new System.Windows.Forms.CheckBox();
            this.chickenCheckBox = new System.Windows.Forms.CheckBox();
            this.tomatoesСheckBox = new System.Windows.Forms.CheckBox();
            this.hotPepperCheckBox = new System.Windows.Forms.CheckBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Items.AddRange(new object[] {
            "Маленька",
            "Средняя",
            "Большая"});
            this.sizeComboBox.Location = new System.Drawing.Point(103, 12);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(121, 21);
            this.sizeComboBox.TabIndex = 0;
            this.sizeComboBox.Text = "Средняя";
            // 
            // doughTypeComboBox
            // 
            this.doughTypeComboBox.FormattingEnabled = true;
            this.doughTypeComboBox.Items.AddRange(new object[] {
            "Классическая",
            "Тонкая"});
            this.doughTypeComboBox.Location = new System.Drawing.Point(103, 49);
            this.doughTypeComboBox.Name = "doughTypeComboBox";
            this.doughTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.doughTypeComboBox.TabIndex = 1;
            this.doughTypeComboBox.Text = "Классическая";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(12, 15);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(49, 13);
            this.sizeLabel.TabIndex = 2;
            this.sizeLabel.Text = "Размер:";
            // 
            // doughTypeLabel
            // 
            this.doughTypeLabel.AutoSize = true;
            this.doughTypeLabel.Location = new System.Drawing.Point(12, 52);
            this.doughTypeLabel.Name = "doughTypeLabel";
            this.doughTypeLabel.Size = new System.Drawing.Size(57, 13);
            this.doughTypeLabel.TabIndex = 3;
            this.doughTypeLabel.Text = "Тип теста";
            // 
            // AdditiveLabel
            // 
            this.AdditiveLabel.AutoSize = true;
            this.AdditiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditiveLabel.Location = new System.Drawing.Point(12, 83);
            this.AdditiveLabel.Name = "AdditiveLabel";
            this.AdditiveLabel.Size = new System.Drawing.Size(123, 16);
            this.AdditiveLabel.TabIndex = 4;
            this.AdditiveLabel.Text = "Добавить к пицце";
            // 
            // mozzarellaCheckBox
            // 
            this.mozzarellaCheckBox.AutoSize = true;
            this.mozzarellaCheckBox.Location = new System.Drawing.Point(15, 111);
            this.mozzarellaCheckBox.Name = "mozzarellaCheckBox";
            this.mozzarellaCheckBox.Size = new System.Drawing.Size(83, 17);
            this.mozzarellaCheckBox.TabIndex = 5;
            this.mozzarellaCheckBox.Text = "Моцарелла";
            this.mozzarellaCheckBox.UseVisualStyleBackColor = true;
            // 
            // baconCheckBox
            // 
            this.baconCheckBox.AutoSize = true;
            this.baconCheckBox.Location = new System.Drawing.Point(15, 134);
            this.baconCheckBox.Name = "baconCheckBox";
            this.baconCheckBox.Size = new System.Drawing.Size(57, 17);
            this.baconCheckBox.TabIndex = 6;
            this.baconCheckBox.Text = "Бекон";
            this.baconCheckBox.UseVisualStyleBackColor = true;
            // 
            // chickenCheckBox
            // 
            this.chickenCheckBox.AutoSize = true;
            this.chickenCheckBox.Location = new System.Drawing.Point(15, 157);
            this.chickenCheckBox.Name = "chickenCheckBox";
            this.chickenCheckBox.Size = new System.Drawing.Size(62, 17);
            this.chickenCheckBox.TabIndex = 7;
            this.chickenCheckBox.Text = "Курица";
            this.chickenCheckBox.UseVisualStyleBackColor = true;
            // 
            // tomatoesСheckBox
            // 
            this.tomatoesСheckBox.AutoSize = true;
            this.tomatoesСheckBox.Location = new System.Drawing.Point(15, 180);
            this.tomatoesСheckBox.Name = "tomatoesСheckBox";
            this.tomatoesСheckBox.Size = new System.Drawing.Size(80, 17);
            this.tomatoesСheckBox.TabIndex = 8;
            this.tomatoesСheckBox.Text = "Помидоры";
            this.tomatoesСheckBox.UseVisualStyleBackColor = true;
            // 
            // hotPepperCheckBox
            // 
            this.hotPepperCheckBox.AutoSize = true;
            this.hotPepperCheckBox.Location = new System.Drawing.Point(15, 203);
            this.hotPepperCheckBox.Name = "hotPepperCheckBox";
            this.hotPepperCheckBox.Size = new System.Drawing.Size(98, 17);
            this.hotPepperCheckBox.TabIndex = 9;
            this.hotPepperCheckBox.Text = "Острый перец";
            this.hotPepperCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(103, 252);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 37);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdditiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 324);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.hotPepperCheckBox);
            this.Controls.Add(this.tomatoesСheckBox);
            this.Controls.Add(this.chickenCheckBox);
            this.Controls.Add(this.baconCheckBox);
            this.Controls.Add(this.mozzarellaCheckBox);
            this.Controls.Add(this.AdditiveLabel);
            this.Controls.Add(this.doughTypeLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.doughTypeComboBox);
            this.Controls.Add(this.sizeComboBox);
            this.Name = "AdditiveForm";
            this.Text = "AdditiveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.ComboBox doughTypeComboBox;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label doughTypeLabel;
        private System.Windows.Forms.Label AdditiveLabel;
        private System.Windows.Forms.CheckBox mozzarellaCheckBox;
        private System.Windows.Forms.CheckBox baconCheckBox;
        private System.Windows.Forms.CheckBox chickenCheckBox;
        private System.Windows.Forms.CheckBox tomatoesСheckBox;
        private System.Windows.Forms.CheckBox hotPepperCheckBox;
        private System.Windows.Forms.Button AddButton;
    }
}