namespace Рекламная_компания
{
    partial class MainMenu
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.allClientReqBtn = new System.Windows.Forms.Button();
            this.FreeAdPlace = new System.Windows.Forms.Button();
            this.BusyAdPlace = new System.Windows.Forms.Button();
            this.zakazWithZakazId = new System.Windows.Forms.Button();
            this.allOrdersByClient = new System.Windows.Forms.Button();
            this.summOrderById = new System.Windows.Forms.Button();
            this.usedMaterial = new System.Windows.Forms.Button();
            this.priceDoneOrders = new System.Windows.Forms.Button();
            this.priceOrderByTime = new System.Windows.Forms.Button();
            this.freePlaceByTime = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userUpdate = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(242, 465);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(226, 35);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // allClientReqBtn
            // 
            this.allClientReqBtn.Location = new System.Drawing.Point(12, 26);
            this.allClientReqBtn.Name = "allClientReqBtn";
            this.allClientReqBtn.Size = new System.Drawing.Size(225, 35);
            this.allClientReqBtn.TabIndex = 1;
            this.allClientReqBtn.Text = "Показать всех клиентов";
            this.allClientReqBtn.UseVisualStyleBackColor = true;
            this.allClientReqBtn.Click += new System.EventHandler(this.allClientReqBtn_Click);
            // 
            // FreeAdPlace
            // 
            this.FreeAdPlace.Location = new System.Drawing.Point(12, 67);
            this.FreeAdPlace.Name = "FreeAdPlace";
            this.FreeAdPlace.Size = new System.Drawing.Size(225, 35);
            this.FreeAdPlace.TabIndex = 2;
            this.FreeAdPlace.Text = "Свободные рекламные места";
            this.FreeAdPlace.UseVisualStyleBackColor = true;
            this.FreeAdPlace.Click += new System.EventHandler(this.FreeAdPlace_Click);
            // 
            // BusyAdPlace
            // 
            this.BusyAdPlace.Location = new System.Drawing.Point(12, 108);
            this.BusyAdPlace.Name = "BusyAdPlace";
            this.BusyAdPlace.Size = new System.Drawing.Size(225, 35);
            this.BusyAdPlace.TabIndex = 3;
            this.BusyAdPlace.Text = "Занятые рекламные места";
            this.BusyAdPlace.UseVisualStyleBackColor = true;
            this.BusyAdPlace.Click += new System.EventHandler(this.BusyAdPlace_Click);
            // 
            // zakazWithZakazId
            // 
            this.zakazWithZakazId.Location = new System.Drawing.Point(11, 149);
            this.zakazWithZakazId.Name = "zakazWithZakazId";
            this.zakazWithZakazId.Size = new System.Drawing.Size(225, 35);
            this.zakazWithZakazId.TabIndex = 4;
            this.zakazWithZakazId.Text = "Справка по заказу";
            this.zakazWithZakazId.UseVisualStyleBackColor = true;
            this.zakazWithZakazId.Click += new System.EventHandler(this.zakazWithZakazId_Click);
            // 
            // allOrdersByClient
            // 
            this.allOrdersByClient.Location = new System.Drawing.Point(12, 190);
            this.allOrdersByClient.Name = "allOrdersByClient";
            this.allOrdersByClient.Size = new System.Drawing.Size(225, 35);
            this.allOrdersByClient.TabIndex = 5;
            this.allOrdersByClient.Text = "Справка заказов по клиенту";
            this.allOrdersByClient.UseVisualStyleBackColor = true;
            this.allOrdersByClient.Click += new System.EventHandler(this.allOrdersByClient_Click);
            // 
            // summOrderById
            // 
            this.summOrderById.Location = new System.Drawing.Point(11, 231);
            this.summOrderById.Name = "summOrderById";
            this.summOrderById.Size = new System.Drawing.Size(225, 35);
            this.summOrderById.TabIndex = 6;
            this.summOrderById.Text = "Cумма заданного заказа";
            this.summOrderById.UseVisualStyleBackColor = true;
            this.summOrderById.Click += new System.EventHandler(this.summOrderById_Click);
            // 
            // usedMaterial
            // 
            this.usedMaterial.Location = new System.Drawing.Point(12, 395);
            this.usedMaterial.Name = "usedMaterial";
            this.usedMaterial.Size = new System.Drawing.Size(225, 35);
            this.usedMaterial.TabIndex = 7;
            this.usedMaterial.Text = "Используемые материалы";
            this.usedMaterial.UseVisualStyleBackColor = true;
            this.usedMaterial.Click += new System.EventHandler(this.usedMaterial_Click);
            // 
            // priceDoneOrders
            // 
            this.priceDoneOrders.Location = new System.Drawing.Point(12, 272);
            this.priceDoneOrders.Name = "priceDoneOrders";
            this.priceDoneOrders.Size = new System.Drawing.Size(225, 35);
            this.priceDoneOrders.TabIndex = 8;
            this.priceDoneOrders.Text = "Cумма выполненных заказов";
            this.priceDoneOrders.UseVisualStyleBackColor = true;
            this.priceDoneOrders.Click += new System.EventHandler(this.priceDoneOrders_Click);
            // 
            // priceOrderByTime
            // 
            this.priceOrderByTime.Location = new System.Drawing.Point(11, 313);
            this.priceOrderByTime.Name = "priceOrderByTime";
            this.priceOrderByTime.Size = new System.Drawing.Size(225, 35);
            this.priceOrderByTime.TabIndex = 9;
            this.priceOrderByTime.Text = "Сумма заказов за время";
            this.priceOrderByTime.UseVisualStyleBackColor = true;
            this.priceOrderByTime.Click += new System.EventHandler(this.priceOrderByTime_Click);
            // 
            // freePlaceByTime
            // 
            this.freePlaceByTime.Location = new System.Drawing.Point(11, 354);
            this.freePlaceByTime.Name = "freePlaceByTime";
            this.freePlaceByTime.Size = new System.Drawing.Size(225, 35);
            this.freePlaceByTime.TabIndex = 10;
            this.freePlaceByTime.Text = "Свободные места за время";
            this.freePlaceByTime.UseVisualStyleBackColor = true;
            this.freePlaceByTime.Click += new System.EventHandler(this.freePlaceByTime_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allClientReqBtn);
            this.groupBox1.Controls.Add(this.FreeAdPlace);
            this.groupBox1.Controls.Add(this.BusyAdPlace);
            this.groupBox1.Controls.Add(this.freePlaceByTime);
            this.groupBox1.Controls.Add(this.zakazWithZakazId);
            this.groupBox1.Controls.Add(this.priceOrderByTime);
            this.groupBox1.Controls.Add(this.allOrdersByClient);
            this.groupBox1.Controls.Add(this.priceDoneOrders);
            this.groupBox1.Controls.Add(this.summOrderById);
            this.groupBox1.Controls.Add(this.usedMaterial);
            this.groupBox1.Location = new System.Drawing.Point(231, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 436);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Простые запросы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userUpdate);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 120);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Запросы на обновление";
            // 
            // userUpdate
            // 
            this.userUpdate.Location = new System.Drawing.Point(6, 43);
            this.userUpdate.Name = "userUpdate";
            this.userUpdate.Size = new System.Drawing.Size(201, 45);
            this.userUpdate.TabIndex = 11;
            this.userUpdate.Text = "Изменить данные ";
            this.userUpdate.UseVisualStyleBackColor = true;
            this.userUpdate.Click += new System.EventHandler(this.editData_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.Location = new System.Drawing.Point(12, 465);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(188, 35);
            this.infoBtn.TabIndex = 15;
            this.infoBtn.Text = "Справка";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 512);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitBtn);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button allClientReqBtn;
        private System.Windows.Forms.Button FreeAdPlace;
        private System.Windows.Forms.Button BusyAdPlace;
        private System.Windows.Forms.Button zakazWithZakazId;
        private System.Windows.Forms.Button allOrdersByClient;
        private System.Windows.Forms.Button summOrderById;
        private System.Windows.Forms.Button usedMaterial;
        private System.Windows.Forms.Button priceDoneOrders;
        private System.Windows.Forms.Button priceOrderByTime;
        private System.Windows.Forms.Button freePlaceByTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button userUpdate;
        private System.Windows.Forms.Button infoBtn;
    }
}