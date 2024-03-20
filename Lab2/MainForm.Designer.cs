namespace Lab2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.chequeGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PizzaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeLabel = new System.Windows.Forms.Label();
            this.costLabel1 = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chequeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chequeGridView
            // 
            this.chequeGridView.AllowUserToAddRows = false;
            this.chequeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chequeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PizzaName,
            this.Prise,
            this.Discription});
            this.chequeGridView.Location = new System.Drawing.Point(12, 32);
            this.chequeGridView.Name = "chequeGridView";
            this.chequeGridView.Size = new System.Drawing.Size(602, 393);
            this.chequeGridView.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(629, 306);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(159, 50);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить позицию";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(629, 375);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(159, 50);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Расчитать чек";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PizzaName
            // 
            this.PizzaName.HeaderText = "Название";
            this.PizzaName.Name = "PizzaName";
            // 
            // Prise
            // 
            this.Prise.HeaderText = "Цена";
            this.Prise.Name = "Prise";
            // 
            // Discription
            // 
            this.Discription.HeaderText = "Описание";
            this.Discription.Name = "Discription";
            this.Discription.Width = 350;
            // 
            // chequeLabel
            // 
            this.chequeLabel.AutoSize = true;
            this.chequeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chequeLabel.Location = new System.Drawing.Point(12, 9);
            this.chequeLabel.Name = "chequeLabel";
            this.chequeLabel.Size = new System.Drawing.Size(58, 20);
            this.chequeLabel.TabIndex = 3;
            this.chequeLabel.Text = "Заказ:";
            // 
            // costLabel1
            // 
            this.costLabel1.AutoSize = true;
            this.costLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel1.Location = new System.Drawing.Point(625, 9);
            this.costLabel1.Name = "costLabel1";
            this.costLabel1.Size = new System.Drawing.Size(82, 20);
            this.costLabel1.TabIndex = 4;
            this.costLabel1.Text = "К оплате:";
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(629, 32);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 20);
            this.costTextBox.TabIndex = 5;
            this.costTextBox.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.costLabel1);
            this.Controls.Add(this.chequeLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.chequeGridView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.chequeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView chequeGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PizzaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prise;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discription;
        private System.Windows.Forms.Label chequeLabel;
        private System.Windows.Forms.Label costLabel1;
        public System.Windows.Forms.TextBox costTextBox;
    }
}

