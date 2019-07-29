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
    public partial class Show : Form
    {
        public static bool check = false;
        public TextBox Seatss, Seans, Price;
        public Label Text1, Text2, Text3;
        public Button newReserv,newFilm;
        public Show()
        {
            InitializeComponent();


            SeatsText();
            SeansText();
            PriceText();
            NewReserv();
            NewFilm();
            Text1Text();
            Text2Text();
            Text3Text();

        }
        public void SeatsText()
        {
            Seatss = new TextBox();
            Seatss.Width = 150;
            Seatss.Height = 20;
            Seatss.Top = 5;
            Seatss.Left = 5;
            Seatss.Enabled = false;
            if (Seats.SeatNum.Count > 0)
            {
                foreach (var seat in Seats.SeatNum)
                {
                    Seatss.Text += seat + ", ";
                }
            }
            else if (Seats2.SeatNum2.Count > 0)
            {
                foreach (var seat in Seats2.SeatNum2)
                {
                    Seatss.Text += seat + ", ";
                }
            }
            else if (Seats3.SeatNum3.Count > 0)
            {
                foreach (var seat in Seats3.SeatNum3)
                {
                    Seatss.Text += seat + ", ";
                }
            }
            else if (Seats4.SeatNum4.Count > 0)
            {
                foreach (var seat in Seats4.SeatNum4)
                {
                    Seatss.Text += seat + ", ";
                }
            }

            Controls.Add(Seatss);

        }
        public void SeansText()
        {
            Seans = new TextBox();
            Seans.Width = 150;
            Seans.Height = 20;
            Seans.Top = 30;
            Seans.Left = 5;
            Seans.Enabled = false;
            Seans.Text = CinemaPanel.combo2.Text;
            Controls.Add(Seans);
        }
        public void PriceText()
        {
            Price = new TextBox();
            Price.Width = 150;
            Price.Height = 20;
            Price.Top = 55;
            Price.Left = 5;
            Price.Enabled = false;
            if (Seats.SeatNum.Count > 0)
            {
                Price.Text = (Seats.SeatNum.Count * 5).ToString();
            }
            else if (Seats2.SeatNum2.Count > 0)
            {
                Price.Text = (Seats2.SeatNum2.Count * 5).ToString();
            }
            else if (Seats3.SeatNum3.Count > 0)
            {
                Price.Text = (Seats3.SeatNum3.Count * 5).ToString();
            }
            else if (Seats4.SeatNum4.Count > 0)
            {
                Price.Text = (Seats4.SeatNum4.Count * 5).ToString();
            }

            Controls.Add(Price);
        }
        public void NewReserv()
        {
            newReserv = new Button();
            newReserv.Width = 80;
            newReserv.Height = 20;
            newReserv.Top = 80;
            newReserv.Left = 20;
            newReserv.Text = "NewReserv";
            newReserv.Click += new EventHandler(newReservData);

            Controls.Add(newReserv);
        }
        public void NewFilm()
        {
            newFilm = new Button();
            newFilm.Width = 80;
            newFilm.Height = 20;
            newFilm.Top = 120;
            newFilm.Left = 20;
            newFilm.Text = "newFilm";
            newFilm.Click += new EventHandler(newFilmData);
            Controls.Add(newFilm);
        }

        private void form_close(object sender, FormClosingEventArgs e)
        {
            if (!check)
            {
                //if(CinemaPanel.)
                if (CinemaPanel.Film2.Checked)
                {
                    Seats.now_form.Close();

                }
                else if (CinemaPanel.Film3.Checked)
                {
                    Seats2.now_form2.Close();

                }
                else if (CinemaPanel.Film4.Checked)
                {
                    Seats3.now_form3.Close();
                }
                else if (CinemaPanel.Film5.Checked)
                {
                    Seats4.now_form4.Close();
                }
                
               
            } 
        }

        public void Text1Text()
        {
            Text1 = new Label();
            Text1.Width = 150;
            Text1.Height = 20;
            Text1.Top = 5;
            Text1.Left = 155;
            Text1.Text = "Reserv elediyiniz yerler";
            Controls.Add(Text1);
        }
        public void Text2Text()
        {
            Text2 = new Label();
            Text2.Width = 150;
            Text2.Height = 20;
            Text2.Top = 30;
            Text2.Left = 155;
            Text2.Text = "Seans";
            Controls.Add(Text2);
        }
        public void Text3Text()
        {
            Text3 = new Label();
            Text3.Width = 150;
            Text3.Height = 20;
            Text3.Top = 55;
            Text3.Left = 155;
            Text3.Text = "Odenilecek mebleg";
            Controls.Add(Text3);
        }


        public void newReservData(object obj,EventArgs e)
        {
            Seans.Text = "";
            check = true;
            this.Close();
            check = false;
        }
        public void newFilmData(object obj,EventArgs e)
        {
            CinemaPanel.combo2.Text = "";
            this.Close();
            if (CinemaPanel.Film2.Checked)
            {
                Seats.now_form.Close();

            }
            else if (CinemaPanel.Film3.Checked)
            {
                Seats2.now_form2.Close();

            }
            else if (CinemaPanel.Film4.Checked)
            {
                Seats3.now_form3.Close();
            }
            else if (CinemaPanel.Film5.Checked)
            {
                Seats4.now_form4.Close();
            }

        }
    }
}
