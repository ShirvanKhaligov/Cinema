using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaER
{
    public partial class Seats2 : Form
    {
        public static Form now_form2;
        
        public int LeftPos = 0;
        public int TopPos = 400;
        public int column = 12;
        public int row = 8;
        public int a = 1, b = 1;
        public Button seat, zal1 = new Button(), resault = new Button();
        public static TextBox resaultText = new TextBox();
        public static List<int> SeatNum2 = new List<int>();
        public Seats2()
        {
            InitializeComponent();
            
            seats();
            Zal2();
            ResaultText();
            Resault();
            now_form2 = this;
        }
        public void seats()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    seat = new Button();
                    seat.Width = 50;
                    seat.Height = 50;
                    seat.Left = LeftPos;
                    seat.Top = TopPos;
                    LeftPos += 50;
                    seat.Text = b.ToString();
                    seat.BackColor = Color.White;
                    seat.FlatStyle = FlatStyle.Flat;
                    seat.Click += new EventHandler(SeatData);
                    Controls.Add(seat);
                    b++;

                }
                LeftPos = 25 * a;
                TopPos -= 50;
                a++;
                column--;


            }
            this.Width = seat.Width * 12 + 17;
            this.Height = 400 + 50 + 40;
        }
        public void Zal2()
        {

            zal1.Width = 80;
            zal1.Height = 30;
            zal1.Top = 5;
            zal1.Left = 259;
            zal1.Text = "ZAL 2";
            zal1.Enabled = false;
            zal1.BackColor = Color.Green;
            zal1.FlatStyle = FlatStyle.Flat;
            Controls.Add(zal1);

        }
        public void SeatData(object obj, EventArgs e)
        {
            Button newseat = obj as Button;
            if (newseat.BackColor == Color.White)
            {
                newseat.BackColor = Color.Green;
                SeatNum2.Add(Convert.ToInt32(newseat.Text));
                resaultText.Text += newseat.Text + ", ";
            }
            else
            {
                newseat.BackColor = Color.White;
                SeatNum2.Remove(Convert.ToInt32(newseat.Text));
                resaultText.Text = "";
                foreach (var num in SeatNum2)
                {
                    resaultText.Text += num + ", ";
                }
            }

        }

        private void seat2_close(object sender, FormClosingEventArgs e)
        {
            foreach (var f in Controls)
            {
                foreach (var h in SeatNum2)

                {
                    if (f is Button)
                    {

                        Button btn = f as Button;

                        if (btn.Text == h.ToString())
                        {
                            if (btn.Enabled == true)
                            {
                                btn.BackColor = Color.White;
                            }

                        }

                    }
                }
            }
        }

        public void ResaultText()
        {
            resaultText.Width = 150;
            resaultText.Height = 20;
            resaultText.Top = 30;
            resaultText.Left = 5;
            resaultText.Multiline = true;
            resaultText.Enabled = false;
            Controls.Add(resaultText);

        }
        public void Resault()
        {
            resault.Width = 80;
            resault.Height = 20;
            resault.Top = 5;
            resault.Left = 5;
            resault.Text = "Reserv";
            resault.Click += new EventHandler(resaultData);
            Controls.Add(resault);

        }
        public void resaultData(object obj, EventArgs e)
        {
            foreach (var j in Controls)
            {


                foreach (var h in SeatNum2)
                {
                    if (j is Button)
                    {
                        Button btn = j as Button;
                        if (btn.Text == h.ToString())
                        {
                            btn.Enabled = false;
                        }
                    }
                }
            }

            resaultText.Text = "";
            Show print = new Show();
            print.ShowDialog();
            //this.Close();
        }
    }
}
