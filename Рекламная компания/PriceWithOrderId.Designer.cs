namespace Рекламная_компания
{
    partial class PriceWithOrderId
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
            this.components = new System.ComponentModel.Container();
            this.zakazIdTB = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.advertisingCompaignDataSet = new Рекламная_компания.AdvertisingCompaignDataSet();
            this.advertisingCompaignDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advertisingCompaignDataSet1 = new Рекламная_компания.AdvertisingCompaignDataSet1();
            this.advertisingCompaignDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.advertisingCompaignDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertisingCompaignDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertisingCompaignDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertisingCompaignDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // zakazIdTB
            // 
            this.zakazIdTB.Location = new System.Drawing.Point(121, 180);
            this.zakazIdTB.Name = "zakazIdTB";
            this.zakazIdTB.Size = new System.Drawing.Size(180, 22);
            this.zakazIdTB.TabIndex = 11;
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(121, 219);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(180, 36);
            this.enterBtn.TabIndex = 10;
            this.enterBtn.Text = "Расчитать";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Location = new System.Drawing.Point(121, 288);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(180, 36);
            this.mainMenuBtn.TabIndex = 9;
            this.mainMenuBtn.Text = "Главное меню";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // advertisingCompaignDataSet
            // 
            this.advertisingCompaignDataSet.DataSetName = "AdvertisingCompaignDataSet";
            this.advertisingCompaignDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advertisingCompaignDataSetBindingSource
            // 
            this.advertisingCompaignDataSetBindingSource.DataSource = this.advertisingCompaignDataSet;
            this.advertisingCompaignDataSetBindingSource.Position = 0;
            // 
            // advertisingCompaignDataSet1
            // 
            this.advertisingCompaignDataSet1.DataSetName = "AdvertisingCompaignDataSet1";
            this.advertisingCompaignDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advertisingCompaignDataSet1BindingSource
            // 
            this.advertisingCompaignDataSet1BindingSource.DataSource = this.advertisingCompaignDataSet1;
            this.advertisingCompaignDataSet1BindingSource.Position = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(9, 7);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(393, 132);
            this.dataGridView.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введите первичный ключ заказа";
            // 
            // PriceWithOrderId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.zakazIdTB);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Name = "PriceWithOrderId";
            this.Text = "Стоимость заданного заказа";
            this.Load += new System.EventHandler(this.PriceWithOrderId_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advertisingCompaignDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertisingCompaignDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertisingCompaignDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertisingCompaignDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zakazIdTB;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.BindingSource advertisingCompaignDataSet1BindingSource;
        private AdvertisingCompaignDataSet1 advertisingCompaignDataSet1;
        private AdvertisingCompaignDataSet advertisingCompaignDataSet;
        private System.Windows.Forms.BindingSource advertisingCompaignDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
    }
}