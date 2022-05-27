namespace Electricity
{
    partial class ElectricityForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.PreviousLabel = new System.Windows.Forms.Label();
            this.CurrentLabel = new System.Windows.Forms.Label();
            this.PreviousBox = new System.Windows.Forms.TextBox();
            this.CurrentBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(10, 10);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(144, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Показания счётчика";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreviousLabel
            // 
            this.PreviousLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousLabel.Location = new System.Drawing.Point(10, 40);
            this.PreviousLabel.Name = "PreviousLabel";
            this.PreviousLabel.Size = new System.Drawing.Size(110, 20);
            this.PreviousLabel.TabIndex = 1;
            this.PreviousLabel.Text = "Предыдущее";
            this.PreviousLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentLabel
            // 
            this.CurrentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentLabel.Location = new System.Drawing.Point(10, 65);
            this.CurrentLabel.Name = "CurrentLabel";
            this.CurrentLabel.Size = new System.Drawing.Size(110, 20);
            this.CurrentLabel.TabIndex = 2;
            this.CurrentLabel.Text = "Текущее";
            this.CurrentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PreviousBox
            // 
            this.PreviousBox.Location = new System.Drawing.Point(130, 40);
            this.PreviousBox.Name = "PreviousBox";
            this.PreviousBox.Size = new System.Drawing.Size(100, 20);
            this.PreviousBox.TabIndex = 3;
            this.PreviousBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreviousBox_KeyPress);
            this.PreviousBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PreviousBox_KeyUp);
            // 
            // CurrentBox
            // 
            this.CurrentBox.Location = new System.Drawing.Point(130, 65);
            this.CurrentBox.Name = "CurrentBox";
            this.CurrentBox.Size = new System.Drawing.Size(100, 20);
            this.CurrentBox.TabIndex = 4;
            this.CurrentBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrentBox_KeyPress);
            this.CurrentBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PreviousBox_KeyUp);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(130, 100);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(100, 20);
            this.PriceBox.TabIndex = 6;
            this.PriceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceBox_KeyPress);
            this.PriceBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PreviousBox_KeyUp);
            // 
            // PriceLabel
            // 
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(10, 100);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(110, 20);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Цена (руб./кВт)";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CalcButton
            // 
            this.CalcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalcButton.Location = new System.Drawing.Point(10, 150);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(90, 30);
            this.CalcButton.TabIndex = 7;
            this.CalcButton.Text = "Вычислить";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.Location = new System.Drawing.Point(110, 150);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(115, 30);
            this.OutputLabel.TabIndex = 8;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElectricityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.CurrentBox);
            this.Controls.Add(this.PreviousBox);
            this.Controls.Add(this.CurrentLabel);
            this.Controls.Add(this.PreviousLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "ElectricityForm";
            this.Text = "Электроэнергия";
            this.Load += new System.EventHandler(this.ElectricityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PreviousLabel;
        private System.Windows.Forms.Label CurrentLabel;
        private System.Windows.Forms.TextBox PreviousBox;
        private System.Windows.Forms.TextBox CurrentBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label OutputLabel;
    }
}

