namespace CinemaER
{
    partial class Film2Fraqman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Film2Fraqman));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.StartFilm = new System.Windows.Forms.Button();
            this.PausaFilm = new System.Windows.Forms.Button();
            this.StopFilm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(425, 332);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // StartFilm
            // 
            this.StartFilm.Location = new System.Drawing.Point(0, 0);
            this.StartFilm.Name = "StartFilm";
            this.StartFilm.Size = new System.Drawing.Size(75, 23);
            this.StartFilm.TabIndex = 0;
            // 
            // PausaFilm
            // 
            this.PausaFilm.Location = new System.Drawing.Point(0, 0);
            this.PausaFilm.Name = "PausaFilm";
            this.PausaFilm.Size = new System.Drawing.Size(75, 23);
            this.PausaFilm.TabIndex = 0;
            // 
            // StopFilm
            // 
            this.StopFilm.Location = new System.Drawing.Point(0, 0);
            this.StopFilm.Name = "StopFilm";
            this.StopFilm.Size = new System.Drawing.Size(75, 23);
            this.StopFilm.TabIndex = 0;
            // 
            // Film2Fraqman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 330);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Film2Fraqman";
            this.Text = "Film2Fraqman";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.film_close);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button StartFilm;
        private System.Windows.Forms.Button PausaFilm;
        private System.Windows.Forms.Button StopFilm;
    }
}