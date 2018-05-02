namespace Рекламная_компания
{
    partial class QueryForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.advertisingCompaignDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advertisingCompaignDataSet = new Рекламная_компания.AdvertisingCompaignDataSet();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertisingCompaignDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertisingCompaignDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(766, 448);
            this.dataGridView.TabIndex = 0;
            // 
            // advertisingCompaignDataSetBindingSource
            // 
            this.advertisingCompaignDataSetBindingSource.DataSource = this.advertisingCompaignDataSet;
            this.advertisingCompaignDataSetBindingSource.Position = 0;
            // 
            // advertisingCompaignDataSet
            // 
            this.advertisingCompaignDataSet.DataSetName = "AdvertisingCompaignDataSet";
            this.advertisingCompaignDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Location = new System.Drawing.Point(784, 12);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(180, 36);
            this.mainMenuBtn.TabIndex = 1;
            this.mainMenuBtn.Text = "Главное меню";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 472);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.dataGridView);
            this.Name = "QueryForm";
            this.Text = "Запрос на всех клиентов";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertisingCompaignDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertisingCompaignDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.BindingSource advertisingCompaignDataSetBindingSource;
        private AdvertisingCompaignDataSet advertisingCompaignDataSet;
    }
}