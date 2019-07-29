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
    public partial class CinemaPanel : Form
    {
        public Seats seatsZal2 = new Seats();
        public Seats2 seatsZal3 = new Seats2();
        public Seats3 seatsZal4 = new Seats3();
        public Seats4 seatsZal5 = new Seats4();

        public static RadioButton Film2 = new RadioButton(), Film3 = new RadioButton(), Film4 = new RadioButton(), Film5 = new RadioButton();
        public static ComboBox combo2 = new ComboBox();
        public static Label combo_label = new Label();        
            
        public static int c;
        public CinemaPanel()
        {
            InitializeComponent();

          
            RadioButtons();
            Seanss();
            Film2.Click += new EventHandler(Film2Data);
            Film3.Click += new EventHandler(Film3Data);
            Film4.Click += new EventHandler(Film4Data);
            Film5.Click += new EventHandler(Film5Data);
            BuyTicket.Click += new EventHandler(BuyTicketData);
        }
       
        public void Film2Data(object obj, EventArgs e)
        {
            filmfraqman.BackgroundImage = global::CinemaER.Properties.Resources.film4;

        }
        public void Film3Data(object obj, EventArgs e)
        {
            filmfraqman.BackgroundImage = global::CinemaER.Properties.Resources.film5;

        }
        public void Film4Data(object obj, EventArgs e)
        {
            filmfraqman.BackgroundImage = global::CinemaER.Properties.Resources.film2;

        }
        public void Film5Data(object obj, EventArgs e)
        {
            filmfraqman.BackgroundImage = global::CinemaER.Properties.Resources.film1;

        }
        public void BuyTicketData(object obj, EventArgs e)
        {

            
                Delete();
                if (Film2.Checked)
                {
                    seatsZal2.ShowDialog();

                }
                else if (Film3.Checked)
                {
                    seatsZal3.ShowDialog();

                }
                else if (Film4.Checked)
                {

                    seatsZal4.ShowDialog();
                }
                else if (Film5.Checked)
                {
                    seatsZal5.ShowDialog();
                }
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            
        }

        private void filmfraqman_Click(object sender, EventArgs e)
        {
            if (Film2.Checked)
            {
                Film2Fraqman film2 = new Film2Fraqman();
                film2.ShowDialog();
            }
            else if (Film3.Checked)
            {
                Film2Fraqman film2 = new Film2Fraqman();
                film2.ShowDialog();
            }
            else if (Film4.Checked)
            {
                Film2Fraqman film2 = new Film2Fraqman();
                film2.ShowDialog();
            }
            else if (Film5.Checked)
            {
                Film2Fraqman film2 = new Film2Fraqman();
                film2.ShowDialog();
            }
        }

        public void RadioButtons()
        {
            Film2.AutoSize = true;
            Film2.BackColor = SystemColors.ActiveBorder;
            Film2.Location = new Point(47, 85);
            Film2.Name = "Film2";
            Film2.Size = new Size(41, 17);
            
            Film2.TabIndex = 1;
            Film2.TabStop = true;
            Film2.Text = "Tor";
            Film2.UseVisualStyleBackColor = false;
            // 
            // Film3
            // 
            Film3.AutoSize = true;
            Film3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            Film3.Location = new System.Drawing.Point(47, 115);
            Film3.Name = "Film3";
            Film3.Size = new System.Drawing.Size(59, 17);
            Film3.TabIndex = 2;
            Film3.TabStop = true;
            Film3.Text = "Hickok";
            Film3.UseVisualStyleBackColor = false;
            // 
            // Film4
            // 
            Film4.AutoSize = true;
            Film4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            Film4.Location = new System.Drawing.Point(47, 145);
            Film4.Name = "Film4";
            Film4.Size = new System.Drawing.Size(104, 17);
            Film4.TabIndex = 3;
            Film4.TabStop = true;
            Film4.Text = "Zombie Diaries 2\r\n";
            Film4.UseVisualStyleBackColor = false;
            // 
            // Film5
            // 
            Film5.AutoSize = true;
            Film5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            Film5.ForeColor = System.Drawing.Color.Black;
            Film5.Location = new System.Drawing.Point(47, 175);
            Film5.Name = "Film5";
            Film5.Size = new System.Drawing.Size(70, 17);
            Film5.TabIndex = 5;
            Film5.TabStop = true;
            Film5.Text = "Qasoskor";
            Film5.UseVisualStyleBackColor = false;
            Controls.Add(Film5);
            Controls.Add(Film4);
            Controls.Add(Film3);
            Controls.Add(Film2);
        }
        public void Delete()
        {
            Seats.resaultText.Text = "";
            Seats2.resaultText.Text = "";
            Seats3.resaultText.Text = "";
            Seats4.resaultText.Text = "";
            Seats2.SeatNum2.Clear();
            Seats.SeatNum.Clear();
            Seats3.SeatNum3.Clear();
            Seats4.SeatNum4.Clear();
            
        }
        public void Seanss()
        {
            combo2.Width = 150;
            combo2.Height = 20;
            combo2.Top = 63;
            combo2.Left = 380;
            combo2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            combo2.FlatStyle = FlatStyle.Flat;
            combo2.Items.AddRange(new string[] {"09:00","11:00", "12:00", "15:00","18:00","21:00","23:00" });
            Controls.Add(combo2);

            combo_label.Width = 70;
            combo_label.Height = 20;
            combo_label.Top = 63;
            combo_label.Left = 300;
            combo_label.FlatStyle = FlatStyle.Flat;
            combo_label.BackColor = Color.Green;

            combo_label.Text = "Seans";
            Controls.Add(combo_label);
        }


    }
    

}

