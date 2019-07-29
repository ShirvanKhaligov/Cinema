namespace CinemaER
{
    partial class CinemaPanel
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
        /// 
        
        private void InitializeComponent()
        {
            this.BuyTicket = new System.Windows.Forms.Button();
            this.filmfraqman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuyTicket
            // 
            this.BuyTicket.BackColor = System.Drawing.Color.Green;
            this.BuyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyTicket.Location = new System.Drawing.Point(214, 232);
            this.BuyTicket.Name = "BuyTicket";
            this.BuyTicket.Size = new System.Drawing.Size(75, 23);
            this.BuyTicket.TabIndex = 8;
            this.BuyTicket.Text = "BUY";
            this.BuyTicket.UseVisualStyleBackColor = false;
            // 
            // filmfraqman
            // 
            this.filmfraqman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filmfraqman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filmfraqman.Location = new System.Drawing.Point(176, 63);
            this.filmfraqman.Name = "filmfraqman";
            this.filmfraqman.Size = new System.Drawing.Size(113, 153);
            this.filmfraqman.TabIndex = 9;
            this.filmfraqman.UseVisualStyleBackColor = true;
            this.filmfraqman.Click += new System.EventHandler(this.filmfraqman_Click);
            // 
            // CinemaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CinemaER.Properties.Resources.cinempanel1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 397);
            this.Controls.Add(this.BuyTicket);
            this.Controls.Add(this.filmfraqman);
            this.MaximizeBox = false;
            this.Name = "CinemaPanel";
            this.Text = "CinemaPanel";
            this.ResumeLayout(false);

        }

        #endregion

       // private System.Windows.Forms.RadioButton Film1;
        private System.Windows.Forms.Button BuyTicket;
        private System.Windows.Forms.Button filmfraqman;
    }
}