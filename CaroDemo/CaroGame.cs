using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaroDemo.Model;

namespace CaroDemo
{
    public partial class CaroGame : Form
    {
        private int flag = 0;
        List<Button> lsBtn = new List<Button>();
        public CaroGame()
        {
            InitializeComponent();
        }



        private void btnBanco_Click(object sender, EventArgs e)
        {
            var sophantu = int.Parse(tbSo.Text);
            pnlContent.Controls.Clear();
            lsBtn.Clear();
            for (int i = 0; i < sophantu; i++)
            {
                FlowLayoutPanel pnlItem = new FlowLayoutPanel();
                pnlItem.FlowDirection = FlowDirection.LeftToRight;
                pnlItem.AutoSize = true;
                pnlItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                pnlContent.Controls.Add(pnlItem);
                for(int j= 0; j < sophantu; j++)
                {
                    ButtonKDB btnItem = new ButtonKDB();
                    btnItem.Width = 20;
                    btnItem.Height = 20;
                    btnItem.Row = i;
                    btnItem.Column = j;
                    btnItem.Click += BtnItem_Click;
                    pnlItem.Controls.Add(btnItem);
                    lsBtn.Add(btnItem);
                }


            }
        }

        private void BtnItem_Click(object sender, EventArgs e)
        {
          
            Button currentButton = (Button)sender;
            if(flag == 0 && String.IsNullOrEmpty(currentButton.Text) == true)
            {
                currentButton.Text = "O";
                    flag = 1;
            }
            else if(flag == 1 && String.IsNullOrEmpty(currentButton.Text) == true)
            {
                currentButton.Text = "X";
                    flag = 0;
            }

        }
    }
}
