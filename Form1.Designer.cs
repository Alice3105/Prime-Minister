namespace PrimeMinsters
{
    partial class frmPrimeMinisters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimeMinisters));
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.lstPrimeMinisters = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblParty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(47, 32);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(216, 257);
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            // 
            // lstPrimeMinisters
            // 
            this.lstPrimeMinisters.FormattingEnabled = true;
            this.lstPrimeMinisters.Location = new System.Drawing.Point(292, 32);
            this.lstPrimeMinisters.Name = "lstPrimeMinisters";
            this.lstPrimeMinisters.Size = new System.Drawing.Size(153, 251);
            this.lstPrimeMinisters.TabIndex = 1;
            this.lstPrimeMinisters.SelectedValueChanged += new System.EventHandler(this.lstPrimeMinisters_SelectedValueChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(58, 303);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 2;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(59, 343);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(37, 13);
            this.lblTerm.TabIndex = 3;
            this.lblTerm.Text = "Term: ";
            // 
            // lblParty
            // 
            this.lblParty.AutoSize = true;
            this.lblParty.Location = new System.Drawing.Point(59, 371);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(37, 13);
            this.lblParty.TabIndex = 4;
            this.lblParty.Text = "Party: ";
            // 
            // frmPrimeMinisters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 412);
            this.Controls.Add(this.lblParty);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstPrimeMinisters);
            this.Controls.Add(this.picPhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrimeMinisters";
            this.Text = "Prime Ministers";
            this.Load += new System.EventHandler(this.frmPrimeMinisters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.ListBox lstPrimeMinisters;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblParty;
    }
}

