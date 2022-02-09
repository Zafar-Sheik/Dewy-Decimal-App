namespace _19015385_PROG7312_POE
{
    partial class frmIdentifyAreas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIdentifyAreas));
            this.lstbxClues = new System.Windows.Forms.ListBox();
            this.lstbxDefinition = new System.Windows.Forms.ListBox();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.imgTrophy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrophy)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbxClues
            // 
            this.lstbxClues.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxClues.FormattingEnabled = true;
            this.lstbxClues.ItemHeight = 14;
            this.lstbxClues.Location = new System.Drawing.Point(165, 62);
            this.lstbxClues.Name = "lstbxClues";
            this.lstbxClues.Size = new System.Drawing.Size(144, 214);
            this.lstbxClues.TabIndex = 0;
            this.lstbxClues.Click += new System.EventHandler(this.lstbxClues_Click);
            this.lstbxClues.SelectedIndexChanged += new System.EventHandler(this.lstbxClues_SelectedIndexChanged);
            // 
            // lstbxDefinition
            // 
            this.lstbxDefinition.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxDefinition.FormattingEnabled = true;
            this.lstbxDefinition.ItemHeight = 14;
            this.lstbxDefinition.Location = new System.Drawing.Point(475, 62);
            this.lstbxDefinition.Name = "lstbxDefinition";
            this.lstbxDefinition.Size = new System.Drawing.Size(185, 242);
            this.lstbxDefinition.TabIndex = 1;
            this.lstbxDefinition.SelectedIndexChanged += new System.EventHandler(this.lstbxDefinition_SelectedIndexChanged);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.btnNextQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextQuestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.Location = new System.Drawing.Point(344, 395);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(109, 43);
            this.btnNextQuestion.TabIndex = 2;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "LETS PLAY! MATCH COLUMN A WITH COLUMN B";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "<<<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(64, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Alternate";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(619, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "VIEW SCORE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imgTrophy
            // 
            this.imgTrophy.BackColor = System.Drawing.Color.Transparent;
            this.imgTrophy.Image = ((System.Drawing.Image)(resources.GetObject("imgTrophy.Image")));
            this.imgTrophy.Location = new System.Drawing.Point(342, 130);
            this.imgTrophy.Name = "imgTrophy";
            this.imgTrophy.Size = new System.Drawing.Size(111, 146);
            this.imgTrophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTrophy.TabIndex = 8;
            this.imgTrophy.TabStop = false;
            this.imgTrophy.Visible = false;
            // 
            // frmIdentifyAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgTrophy);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.lstbxDefinition);
            this.Controls.Add(this.lstbxClues);
            this.Name = "frmIdentifyAreas";
            this.Text = "frmIdentifyAreas";
            this.Load += new System.EventHandler(this.frmIdentifyAreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgTrophy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxClues;
        private System.Windows.Forms.ListBox lstbxDefinition;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox imgTrophy;
    }
}