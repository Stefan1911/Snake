namespace Snake
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
            this.HeadBt = new System.Windows.Forms.Button();
            this.startBt = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // HeadBt
            // 
            this.HeadBt.Enabled = false;
            this.HeadBt.Location = new System.Drawing.Point(191, 258);
            this.HeadBt.Name = "HeadBt";
            this.HeadBt.Size = new System.Drawing.Size(30, 30);
            this.HeadBt.TabIndex = 0;
            this.HeadBt.UseVisualStyleBackColor = true;
            this.HeadBt.Visible = false;
            this.HeadBt.Click += new System.EventHandler(this.HeadBt_Click);
            // 
            // startBt
            // 
            this.startBt.Location = new System.Drawing.Point(397, 217);
            this.startBt.Name = "startBt";
            this.startBt.Size = new System.Drawing.Size(259, 98);
            this.startBt.TabIndex = 1;
            this.startBt.Text = "Start the Game";
            this.startBt.UseVisualStyleBackColor = true;
            this.startBt.Click += new System.EventHandler(this.startBt_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 400;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 601);
            this.Controls.Add(this.startBt);
            this.Controls.Add(this.HeadBt);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button HeadBt;
        private System.Windows.Forms.Button startBt;
        private System.Windows.Forms.Timer gameTimer;
    }
}

