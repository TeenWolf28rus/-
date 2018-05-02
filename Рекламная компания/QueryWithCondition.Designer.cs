namespace Рекламная_компания
{
    partial class QueryWithCondition
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
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.enterBtn = new System.Windows.Forms.Button();
            this.zakazIdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Location = new System.Drawing.Point(784, 12);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(180, 36);
            this.mainMenuBtn.TabIndex = 5;
            this.mainMenuBtn.Text = "Главное меню";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(766, 448);
            this.dataGridView.TabIndex = 4;
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(784, 363);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(180, 36);
            this.enterBtn.TabIndex = 6;
            this.enterBtn.Text = "Выполнить";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // zakazIdTB
            // 
            this.zakazIdTB.Location = new System.Drawing.Point(784, 335);
            this.zakazIdTB.Name = "zakazIdTB";
            this.zakazIdTB.Size = new System.Drawing.Size(180, 22);
            this.zakazIdTB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите первичный ключ";
            // 
            // QueryWithCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zakazIdTB);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.dataGridView);
            this.Name = "QueryWithCondition";
            this.Text = "Справка по заданному заказу";
            this.Load += new System.EventHandler(this.QueryWithCondition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.TextBox zakazIdTB;
        private System.Windows.Forms.Label label1;
    }
}