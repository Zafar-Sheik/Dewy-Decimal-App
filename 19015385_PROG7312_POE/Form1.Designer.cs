namespace _19015385_PROG7312_POE
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.ReplacingBooksPageButton = new System.Windows.Forms.Button();
            this.IdentifyingAreasPageButton = new System.Windows.Forms.Button();
            this.FindingCallNumbersPageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReplacingBooksPageButton
            // 
            this.ReplacingBooksPageButton.BackColor = System.Drawing.SystemColors.Window;
            this.ReplacingBooksPageButton.Location = new System.Drawing.Point(31, 12);
            this.ReplacingBooksPageButton.Name = "ReplacingBooksPageButton";
            this.ReplacingBooksPageButton.Size = new System.Drawing.Size(272, 43);
            this.ReplacingBooksPageButton.TabIndex = 0;
            this.ReplacingBooksPageButton.Text = "Replacing Books";
            this.ReplacingBooksPageButton.UseVisualStyleBackColor = false;
            this.ReplacingBooksPageButton.Click += new System.EventHandler(this.ReplacingBooksPageButton_Click);
            // 
            // IdentifyingAreasPageButton
            // 
            this.IdentifyingAreasPageButton.BackColor = System.Drawing.SystemColors.Window;
            this.IdentifyingAreasPageButton.Location = new System.Drawing.Point(31, 61);
            this.IdentifyingAreasPageButton.Name = "IdentifyingAreasPageButton";
            this.IdentifyingAreasPageButton.Size = new System.Drawing.Size(272, 56);
            this.IdentifyingAreasPageButton.TabIndex = 1;
            this.IdentifyingAreasPageButton.Text = "Identifying Areas";
            this.IdentifyingAreasPageButton.UseVisualStyleBackColor = false;
            this.IdentifyingAreasPageButton.Click += new System.EventHandler(this.IdentifyingAreasPageButton_Click);
            // 
            // FindingCallNumbersPageButton
            // 
            this.FindingCallNumbersPageButton.BackColor = System.Drawing.SystemColors.Window;
            this.FindingCallNumbersPageButton.Enabled = false;
            this.FindingCallNumbersPageButton.Location = new System.Drawing.Point(31, 123);
            this.FindingCallNumbersPageButton.Name = "FindingCallNumbersPageButton";
            this.FindingCallNumbersPageButton.Size = new System.Drawing.Size(272, 49);
            this.FindingCallNumbersPageButton.TabIndex = 2;
            this.FindingCallNumbersPageButton.Text = "Finding Call Numbers";
            this.FindingCallNumbersPageButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "DEWY THE LIBRARIAN";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(345, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindingCallNumbersPageButton);
            this.Controls.Add(this.IdentifyingAreasPageButton);
            this.Controls.Add(this.ReplacingBooksPageButton);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReplacingBooksPageButton;
        private System.Windows.Forms.Button IdentifyingAreasPageButton;
        private System.Windows.Forms.Button FindingCallNumbersPageButton;
        private System.Windows.Forms.Label label1;
    }
}

