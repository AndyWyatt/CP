namespace CP.CP11Rocket
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.pbRocket = new System.Windows.Forms.PictureBox();
            this.timCountDown = new System.Windows.Forms.Timer(this.components);
            this.timRocketUp = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbRocket)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.Location = new System.Drawing.Point(437, 9);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(174, 46);
            this.lblCountDown.TabIndex = 0;
            this.lblCountDown.Text = "Time: 10";
            // 
            // pbRocket
            // 
            this.pbRocket.Image = global::CP.CP11Rocket.Properties.Resources.rocket;
            this.pbRocket.Location = new System.Drawing.Point(30, 279);
            this.pbRocket.Name = "pbRocket";
            this.pbRocket.Size = new System.Drawing.Size(176, 189);
            this.pbRocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRocket.TabIndex = 1;
            this.pbRocket.TabStop = false;
            // 
            // timCountDown
            // 
            this.timCountDown.Enabled = true;
            this.timCountDown.Interval = 1000;
            this.timCountDown.Tick += new System.EventHandler(this.timCountDown_Tick);
            // 
            // timRocketUp
            // 
            this.timRocketUp.Interval = 50;
            this.timRocketUp.Tick += new System.EventHandler(this.timRocketUp_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(623, 425);
            this.Controls.Add(this.pbRocket);
            this.Controls.Add(this.lblCountDown);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbRocket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.PictureBox pbRocket;
        private System.Windows.Forms.Timer timCountDown;
        private System.Windows.Forms.Timer timRocketUp;
    }
}

