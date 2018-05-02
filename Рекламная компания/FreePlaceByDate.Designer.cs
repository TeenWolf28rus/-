namespace Рекламная_компания
{
    partial class FreePlaceByDate
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
            this.secondDP = new System.Windows.Forms.DateTimePicker();
            this.firstDP = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.enterBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // secondDP
            // 
            this.secondDP.Location = new System.Drawing.Point(321, 202);
            this.secondDP.Name = "secondDP";
            this.secondDP.Size = new System.Drawing.Size(145, 22);
            this.secondDP.TabIndex = 23;
            // 
            // firstDP
            // 
            this.firstDP.CustomFormat = "20.12.2017";
            this.firstDP.Location = new System.Drawing.Point(102, 202);
            this.firstDP.Name = "firstDP";
            this.firstDP.Size = new System.Drawing.Size(145, 22);
            this.firstDP.TabIndex = 22;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(73, 16);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(393, 132);
            this.dataGridView.TabIndex = 21;
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(321, 306);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(145, 36);
            this.enterBtn.TabIndex = 20;
            this.enterBtn.Text = "Показать";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Location = new System.Drawing.Point(73, 306);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(145, 36);
            this.mainMenuBtn.TabIndex = 19;
            this.mainMenuBtn.Text = "Главное меню";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Выберете временные рамки для запроса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "От";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "До";
            // 
            // FreePlaceByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 359);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondDP);
            this.Controls.Add(this.firstDP);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Name = "FreePlaceByDate";
            this.Text = "Свободные места за заданный период времени";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker secondDP;
        private System.Windows.Forms.DateTimePicker firstDP;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}