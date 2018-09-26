using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MilkTea_app.BLL;

namespace MilkTea_app
{
    public partial class AppMilkTea : Form
    {
        bool isOrderFood = true;
        bool isOrderDrink = true;
        bool isOrderTopping = true;

        DataStore data = new DataStore();
        List<object> component = new List<object>();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        /*chưa cần*/
        private void AddOject()
        {
            component.Add(btnOrderDrinks);
            component.Add(panelCategoryDrinkOrder);
            component.Add(btnOrderFood);
            component.Add(panelCategoryFoodOrder);
        }
        private void AddScroll(Button btn)
        {
            label.Location = new Point(label.Location.X, btn.Location.Y);
            
        }
        public AppMilkTea()
        {
            InitializeComponent();
            pnLogo.BorderStyle = BorderStyle.None;
            panelOrder1.SetWidthHeight(panelOrder1.Width, panelOrder1.Height);
            AddDrinkCategory();
            AddFoodCategory();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void MoveButtonOverFlow()
        {
            if (isOrderFood)
            {
                btnOrderFood.Location = new Point(btnOrderFood.Location.X, btnOrderFood.Location.Y + panelCategoryDrinkOrder.Height);
        

            }
            else
            {
                btnOrderFood.Location = new Point(btnOrderFood.Location.X, btnOrderFood.Location.Y - panelCategoryDrinkOrder.Height);
               
            }
            panelCategoryFoodOrder.Location = new Point(btnOrderFood.Location.X + 25, btnOrderFood.Location.Y + 70);
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button btnTemp = sender as Button;

            if (isOrderFood)
            {
                panelCategoryDrinkOrder.AutoSize = true;
                MoveButtonOverFlow();
                AddScroll(btnTemp);
                isOrderFood = false;
                
            }
            else
            {
                MoveButtonOverFlow();
                panelCategoryDrinkOrder.AutoSize = false;
                isOrderFood = true;
            }
                

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btnTemp = sender as Button;
            if (isOrderDrink)
            {
                panelCategoryFoodOrder.AutoSize = true;
                isOrderDrink = false;
                AddScroll(btnTemp);
            }
            else
            {
                panelCategoryFoodOrder.AutoSize = false;
                isOrderDrink = true;
            }
        }
        /*add category*/

            private void AddDrinkCategory()
        {
            int xBtn = 0, yBtn = 0;
            Button btn;

            foreach(var temp in data.getCategoryDrink())
            {
                btn = new Button();
                btn.Size = new Size(180, 40);
                btn.Location = new Point(xBtn, yBtn);
                btn.FlatAppearance.BorderSize = 0;
                btn.Text = temp.name;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Click += Btn_Click;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                yBtn = yBtn + 50;
                panelCategoryDrinkOrder.Controls.Add(btn);

            }

        }
        private void AddFoodCategory()
        {
            int xBtn = 0, yBtn = 0;
            Button btn;

            foreach (var temp in data.getCategoryFood())
            {
                btn = new Button();
                btn.Size = new Size(180, 40);
                btn.Location = new Point(xBtn, yBtn);
                btn.FlatAppearance.BorderSize = 0;
                btn.Text = temp.name;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Click += Btn_Click;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                yBtn = yBtn + 50;
                panelCategoryFoodOrder.Controls.Add(btn);

            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn= sender as Button;
            panelOrder1.LoadData(btn.Text);

        }

        private void AppMilkTea_Load(object sender, EventArgs e)
        {

        }

        private void panelOrder1_Load(object sender, EventArgs e)
        {

        }

        private void panelOrder1_Resize(object sender, EventArgs e)
        {
           
        }
    }
}
