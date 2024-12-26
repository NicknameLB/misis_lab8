namespace misis_lab8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPower = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnDoor = new System.Windows.Forms.Button();
            this.chkWater = new System.Windows.Forms.CheckBox();
            this.chkPowder = new System.Windows.Forms.CheckBox();
            this.chkDetergent = new System.Windows.Forms.CheckBox();
            this.chkClothes = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(13, 12);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(95, 23);
            this.btnPower.TabIndex = 0;
            this.btnPower.Text = "on/off";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(121, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 4;
            // 
            // btnDoor
            // 
            this.btnDoor.Location = new System.Drawing.Point(11, 245);
            this.btnDoor.Name = "btnDoor";
            this.btnDoor.Size = new System.Drawing.Size(97, 23);
            this.btnDoor.TabIndex = 5;
            this.btnDoor.Text = "open/close door";
            this.btnDoor.UseVisualStyleBackColor = true;
            this.btnDoor.Click += new System.EventHandler(this.btnDoor_Click);
            // 
            // chkWater
            // 
            this.chkWater.AutoSize = true;
            this.chkWater.Location = new System.Drawing.Point(11, 93);
            this.chkWater.Name = "chkWater";
            this.chkWater.Size = new System.Drawing.Size(52, 17);
            this.chkWater.TabIndex = 7;
            this.chkWater.Text = "water";
            this.chkWater.UseVisualStyleBackColor = true;
            // 
            // chkPowder
            // 
            this.chkPowder.AutoSize = true;
            this.chkPowder.Location = new System.Drawing.Point(11, 116);
            this.chkPowder.Name = "chkPowder";
            this.chkPowder.Size = new System.Drawing.Size(103, 17);
            this.chkPowder.TabIndex = 8;
            this.chkPowder.Text = "washing powder";
            this.chkPowder.UseVisualStyleBackColor = true;
            // 
            // chkDetergent
            // 
            this.chkDetergent.AutoSize = true;
            this.chkDetergent.Location = new System.Drawing.Point(11, 139);
            this.chkDetergent.Name = "chkDetergent";
            this.chkDetergent.Size = new System.Drawing.Size(71, 17);
            this.chkDetergent.TabIndex = 9;
            this.chkDetergent.Text = "detergent";
            this.chkDetergent.UseVisualStyleBackColor = true;
            // 
            // chkClothes
            // 
            this.chkClothes.AutoSize = true;
            this.chkClothes.Location = new System.Drawing.Point(11, 274);
            this.chkClothes.Name = "chkClothes";
            this.chkClothes.Size = new System.Drawing.Size(60, 17);
            this.chkClothes.TabIndex = 10;
            this.chkClothes.Text = "clothes";
            this.chkClothes.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 232);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(310, 12);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(265, 48);
            this.rtbMessages.TabIndex = 13;
            this.rtbMessages.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(410, 354);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkClothes);
            this.Controls.Add(this.chkDetergent);
            this.Controls.Add(this.chkPowder);
            this.Controls.Add(this.chkWater);
            this.Controls.Add(this.btnDoor);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnPower);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnDoor;
        private System.Windows.Forms.CheckBox chkWater;
        private System.Windows.Forms.CheckBox chkPowder;
        private System.Windows.Forms.CheckBox chkDetergent;
        private System.Windows.Forms.CheckBox chkClothes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.Button btnStart;
    }
}

