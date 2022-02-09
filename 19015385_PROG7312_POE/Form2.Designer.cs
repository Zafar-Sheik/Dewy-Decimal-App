namespace _19015385_PROG7312_POE
{
    partial class frmReplacingBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplacingBooks));
            this.lstbxCallNumbers = new System.Windows.Forms.ListBox();
            this.btnGenerateCallNumbers = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.lstBoxUserSort = new System.Windows.Forms.ListBox();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.imgTrophy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrophy)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbxCallNumbers
            // 
            this.lstbxCallNumbers.AllowDrop = true;
            this.lstbxCallNumbers.FormattingEnabled = true;
            this.lstbxCallNumbers.Location = new System.Drawing.Point(13, 49);
            this.lstbxCallNumbers.Name = "lstbxCallNumbers";
            this.lstbxCallNumbers.Size = new System.Drawing.Size(213, 316);
            this.lstbxCallNumbers.TabIndex = 0;
            this.lstbxCallNumbers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstbxCallNumbers_MouseDown);
            // 
            // btnGenerateCallNumbers
            // 
            this.btnGenerateCallNumbers.BackColor = System.Drawing.SystemColors.Window;
            this.btnGenerateCallNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCallNumbers.Location = new System.Drawing.Point(13, 371);
            this.btnGenerateCallNumbers.Name = "btnGenerateCallNumbers";
            this.btnGenerateCallNumbers.Size = new System.Drawing.Size(213, 56);
            this.btnGenerateCallNumbers.TabIndex = 1;
            this.btnGenerateCallNumbers.Text = "Generate Call Numbers";
            this.btnGenerateCallNumbers.UseVisualStyleBackColor = false;
            this.btnGenerateCallNumbers.Click += new System.EventHandler(this.NewRandomButton_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Window;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(269, 371);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 56);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.SystemColors.Window;
            this.HomeButton.Location = new System.Drawing.Point(13, 13);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(213, 23);
            this.HomeButton.TabIndex = 4;
            this.HomeButton.Text = "Back";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // lstBoxUserSort
            // 
            this.lstBoxUserSort.AllowDrop = true;
            this.lstBoxUserSort.FormattingEnabled = true;
            this.lstBoxUserSort.Location = new System.Drawing.Point(269, 49);
            this.lstBoxUserSort.Name = "lstBoxUserSort";
            this.lstBoxUserSort.Size = new System.Drawing.Size(134, 316);
            this.lstBoxUserSort.TabIndex = 5;
            this.lstBoxUserSort.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.lstBoxUserSort.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.BackColor = System.Drawing.SystemColors.Window;
            this.btnHowToPlay.Location = new System.Drawing.Point(269, 13);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(134, 23);
            this.btnHowToPlay.TabIndex = 6;
            this.btnHowToPlay.Text = "How To Play?";
            this.btnHowToPlay.UseVisualStyleBackColor = false;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // imgTrophy
            // 
            this.imgTrophy.BackColor = System.Drawing.Color.Transparent;
            this.imgTrophy.Image = ((System.Drawing.Image)(resources.GetObject("imgTrophy.Image")));
            this.imgTrophy.Location = new System.Drawing.Point(439, 133);
            this.imgTrophy.Name = "imgTrophy";
            this.imgTrophy.Size = new System.Drawing.Size(111, 146);
            this.imgTrophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTrophy.TabIndex = 7;
            this.imgTrophy.TabStop = false;
            this.imgTrophy.Visible = false;
            // 
            // frmReplacingBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(575, 443);
            this.Controls.Add(this.imgTrophy);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.lstBoxUserSort);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnGenerateCallNumbers);
            this.Controls.Add(this.lstbxCallNumbers);
            this.Name = "frmReplacingBooks";
            this.Text = "Replacing Books";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgTrophy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxCallNumbers;
        private System.Windows.Forms.Button btnGenerateCallNumbers;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.ListBox lstBoxUserSort;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.PictureBox imgTrophy;
    }
}