namespace Temperature_Change_Event_Example
{
    partial class main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlTemp1 = new Temperature_Change_Event_Example.ctrlTemp();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Temperature_Change_Event_Example.Properties.Resources.Two_Thermometers;
            this.pictureBox1.Location = new System.Drawing.Point(349, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlTemp1
            // 
            this.ctrlTemp1.Location = new System.Drawing.Point(-3, 12);
            this.ctrlTemp1.Name = "ctrlTemp1";
            this.ctrlTemp1.Size = new System.Drawing.Size(368, 289);
            this.ctrlTemp1.TabIndex = 0;
            this.ctrlTemp1.TemperatureChanged += new System.EventHandler<Temperature_Change_Event_Example.ctrlTemp.TemperatureChangedEventArgs>(this.ctrlTemp1_TemperatureChanged);
            this.ctrlTemp1.Load += new System.EventHandler(this.ctrlTemp1_Load);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 328);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrlTemp1);
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTemp ctrlTemp1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}