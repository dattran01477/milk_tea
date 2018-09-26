using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilkTea_app.BLL;
using MilkTea_app.DTO;

namespace MilkTea_app
{
    public partial class PanelOrder : UserControl
    {
        private DataStore  data= new DataStore();
        private int X,Y=0;

        int width;
        int height;

        private string collectorName;

        public int Height1 { get => height; set => height = value; }
        public int Width1 { get => width; set => width = value; }
        public string CollectorName { get => collectorName; set => collectorName = value; }

        public PanelOrder()
        {
            InitializeComponent();
           
        }
       public void SetWidthHeight(int width,int height)
        {
             this.width=width/4*3;
             this.height=height;
            LoadData(collectorName);
        }
        public void LoadData(string collName)
        {
            X = 0;
            Y = 0;
            pnBtnProducts.Controls.Clear();
            collectorName = collName;
            List<Products> products = new List<Products>();
            products = data.getProduct(collectorName);
            AddButton(products);
        }

        

        private void AddButton(List<Products> products)
        { 
            Button btn;
            Random rnd = new Random();
            foreach(var a in products)
            {
                if (X + 140 >= Width1)
                {
                    Y = Y + 70;
                    X = 0;
                }
                btn = new Button();
                btn.FlatStyle = FlatStyle.Flat;
                btn.Size = new Size(140, 60);
                btn.Text = a.name;
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                btn.Location = new Point(X, Y);
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = randomColor;
             
             
                X = X + 140;
                pnBtnProducts.Controls.Add(btn);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
