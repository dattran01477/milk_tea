﻿namespace MilkTea_app
{
    partial class AppMilkTea
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
            this.SideBar = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.panelCategoryFoodOrder = new System.Windows.Forms.Panel();
            this.panelCategoryDrinkOrder = new System.Windows.Forms.Panel();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOrderFood = new System.Windows.Forms.Button();
            this.btnOrderDrinks = new System.Windows.Forms.Button();
            this.pnTopBar = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.pnDGV = new System.Windows.Forms.Panel();
            this.panelOrder1 = new MilkTea_app.PanelOrder();
            this.pnOrderTopping = new System.Windows.Forms.Panel();
            this.Topping = new System.Windows.Forms.Button();
            this.SideBar.SuspendLayout();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnTopBar.SuspendLayout();
            this.pnDGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.SideBar.Controls.Add(this.pnOrderTopping);
            this.SideBar.Controls.Add(this.Topping);
            this.SideBar.Controls.Add(this.label);
            this.SideBar.Controls.Add(this.panelCategoryFoodOrder);
            this.SideBar.Controls.Add(this.panelCategoryDrinkOrder);
            this.SideBar.Controls.Add(this.pnLogo);
            this.SideBar.Controls.Add(this.btnOrderFood);
            this.SideBar.Controls.Add(this.btnOrderDrinks);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(231, 674);
            this.SideBar.TabIndex = 0;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(178)))), ((int)(((byte)(183)))));
            this.label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(178)))), ((int)(((byte)(183)))));
            this.label.Location = new System.Drawing.Point(219, 212);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(10, 62);
            this.label.TabIndex = 3;
            // 
            // panelCategoryFoodOrder
            // 
            this.panelCategoryFoodOrder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCategoryFoodOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.panelCategoryFoodOrder.Location = new System.Drawing.Point(25, 352);
            this.panelCategoryFoodOrder.Name = "panelCategoryFoodOrder";
            this.panelCategoryFoodOrder.Size = new System.Drawing.Size(184, 10);
            this.panelCategoryFoodOrder.TabIndex = 4;
            // 
            // panelCategoryDrinkOrder
            // 
            this.panelCategoryDrinkOrder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCategoryDrinkOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.panelCategoryDrinkOrder.Location = new System.Drawing.Point(26, 275);
            this.panelCategoryDrinkOrder.Name = "panelCategoryDrinkOrder";
            this.panelCategoryDrinkOrder.Size = new System.Drawing.Size(184, 13);
            this.panelCategoryDrinkOrder.TabIndex = 3;
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.pnLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLogo.Controls.Add(this.label1);
            this.pnLogo.Controls.Add(this.pictureBox1);
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(232, 179);
            this.pnLogo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "The Best Of Milk Tea";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MilkTea_app.Properties.Resources.logo21;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnOrderFood
            // 
            this.btnOrderFood.FlatAppearance.BorderSize = 0;
            this.btnOrderFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderFood.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnOrderFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.btnOrderFood.Image = global::MilkTea_app.Properties.Resources.tray__1_;
            this.btnOrderFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderFood.Location = new System.Drawing.Point(0, 289);
            this.btnOrderFood.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOrderFood.Name = "btnOrderFood";
            this.btnOrderFood.Size = new System.Drawing.Size(213, 62);
            this.btnOrderFood.TabIndex = 2;
            this.btnOrderFood.Text = "Order Foods";
            this.btnOrderFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderFood.UseVisualStyleBackColor = true;
            this.btnOrderFood.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnOrderDrinks
            // 
            this.btnOrderDrinks.FlatAppearance.BorderSize = 0;
            this.btnOrderDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDrinks.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDrinks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.btnOrderDrinks.Image = global::MilkTea_app.Properties.Resources.tray__1_;
            this.btnOrderDrinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderDrinks.Location = new System.Drawing.Point(0, 212);
            this.btnOrderDrinks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOrderDrinks.Name = "btnOrderDrinks";
            this.btnOrderDrinks.Size = new System.Drawing.Size(213, 62);
            this.btnOrderDrinks.TabIndex = 0;
            this.btnOrderDrinks.Text = "Order Drinks";
            this.btnOrderDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderDrinks.UseVisualStyleBackColor = true;
            this.btnOrderDrinks.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnTopBar
            // 
            this.pnTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.pnTopBar.Controls.Add(this.button5);
            this.pnTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopBar.Location = new System.Drawing.Point(231, 0);
            this.pnTopBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnTopBar.Name = "pnTopBar";
            this.pnTopBar.Size = new System.Drawing.Size(1144, 65);
            this.pnTopBar.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImage = global::MilkTea_app.Properties.Resources.cancel_music;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(1111, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // pnDGV
            // 
            this.pnDGV.Controls.Add(this.panelOrder1);
            this.pnDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDGV.Location = new System.Drawing.Point(231, 65);
            this.pnDGV.Name = "pnDGV";
            this.pnDGV.Size = new System.Drawing.Size(1144, 609);
            this.pnDGV.TabIndex = 2;
            // 
            // panelOrder1
            // 
            this.panelOrder1.CollectorName = null;
            this.panelOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrder1.Height1 = 0;
            this.panelOrder1.Location = new System.Drawing.Point(0, 0);
            this.panelOrder1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelOrder1.Name = "panelOrder1";
            this.panelOrder1.Size = new System.Drawing.Size(1144, 609);
            this.panelOrder1.TabIndex = 0;
            this.panelOrder1.Width1 = 0;
            // 
            // pnOrderTopping
            // 
            this.pnOrderTopping.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnOrderTopping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.pnOrderTopping.Location = new System.Drawing.Point(29, 426);
            this.pnOrderTopping.Name = "pnOrderTopping";
            this.pnOrderTopping.Size = new System.Drawing.Size(184, 10);
            this.pnOrderTopping.TabIndex = 6;
            // 
            // Topping
            // 
            this.Topping.FlatAppearance.BorderSize = 0;
            this.Topping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Topping.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Topping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Topping.Image = global::MilkTea_app.Properties.Resources.tray__1_;
            this.Topping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Topping.Location = new System.Drawing.Point(4, 363);
            this.Topping.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Topping.Name = "Topping";
            this.Topping.Size = new System.Drawing.Size(213, 62);
            this.Topping.TabIndex = 5;
            this.Topping.Text = "Topping";
            this.Topping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Topping.UseVisualStyleBackColor = true;
            // 
            // AppMilkTea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1375, 674);
            this.Controls.Add(this.pnDGV);
            this.Controls.Add(this.pnTopBar);
            this.Controls.Add(this.SideBar);
            this.Font = new System.Drawing.Font("MS Reference Specialty", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AppMilkTea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trà Sữa Di&Pi";
            this.Load += new System.EventHandler(this.AppMilkTea_Load);
            this.SideBar.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnTopBar.ResumeLayout(false);
            this.pnDGV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel pnTopBar;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panelCategoryFoodOrder;
        private System.Windows.Forms.Button btnOrderFood;
        private System.Windows.Forms.Panel panelCategoryDrinkOrder;
        private System.Windows.Forms.Button btnOrderDrinks;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnDGV;
        private PanelOrder panelOrder1;
        private System.Windows.Forms.Panel pnOrderTopping;
        private System.Windows.Forms.Button Topping;
    }
}

