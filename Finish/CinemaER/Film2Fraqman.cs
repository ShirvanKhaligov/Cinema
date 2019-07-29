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
    public partial class Film2Fraqman : Form
    {
        public Film2Fraqman()
        {
            InitializeComponent();
            this.BackColor = Color.Red;
        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            if ( CinemaPanel.Film2.Checked)
            {
                axWindowsMediaPlayer1.URL = "C:/Users/HP/source/repos/CinemaER/CinemaER/video/videoplayback.mp4";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (CinemaPanel.Film3.Checked)
            {
                axWindowsMediaPlayer1.URL = "C:/Users/HP/source/repos/CinemaER/CinemaER/video/videoplayback3.mp4";
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }
            else if (CinemaPanel.Film4.Checked)
            {
                axWindowsMediaPlayer1.URL = "C:/Users/HP/source/repos/CinemaER/CinemaER/video/videoplayback4.mp4";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (CinemaPanel.Film5.Checked)
            {
                axWindowsMediaPlayer1.URL = "C:/Users/HP/source/repos/CinemaER/CinemaER/video/videoplayback 5.mp4";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            
        }

        private void film_close(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
