namespace MilkTea_app
{
    partial class PanelOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnBtnProducts = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnOrderDrinks = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.pnBtnProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 552);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 302);
            this.dataGridView1.TabIndex = 1;
            // 
            // pnBtnProducts
            // 
            this.pnBtnProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBtnProducts.Location = new System.Drawing.Point(0, 302);
            this.pnBtnProducts.Name = "pnBtnProducts";
            this.pnBtnProducts.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.pnBtnProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnBtnProducts.Size = new System.Drawing.Size(800, 250);
            this.pnBtnProducts.TabIndex = 0;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnMenu.Controls.Add(this.btnOrderDrinks);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMenu.Location = new System.Drawing.Point(799, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(208, 552);
            this.pnMenu.TabIndex = 1;
            // 
            // btnOrderDrinks
            // 
            this.btnOrderDrinks.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnOrderDrinks.FlatAppearance.BorderSize = 2;
            this.btnOrderDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderDrinks.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDrinks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.btnOrderDrinks.Image = global::MilkTea_app.Properties.Resources.tray__1_;
            this.btnOrderDrinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderDrinks.Location = new System.Drawing.Point(-5, 486);
            this.btnOrderDrinks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOrderDrinks.Name = "btnOrderDrinks";
            this.btnOrderDrinks.Size = new System.Drawing.Size(213, 62);
            this.btnOrderDrinks.TabIndex = 1;
            this.btnOrderDrinks.Text = "Thanh Toán";
            this.btnOrderDrinks.UseCompatibleTextRendering = true;
            this.btnOrderDrinks.UseVisualStyleBackColor = true;
            // 
            // PanelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.panel1);
            this.Name = "PanelOrder";
            this.Size = new System.Drawing.Size(1007, 552);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnBtnProducts;
        private System.Windows.Forms.Button btnOrderDrinks;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
