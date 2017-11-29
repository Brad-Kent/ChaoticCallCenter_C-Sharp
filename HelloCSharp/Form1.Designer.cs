namespace HelloCSharp
{
    partial class FrameMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fldEmail = new System.Windows.Forms.TextBox();
            this.fldPhoneNo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.fldLastName = new System.Windows.Forms.TextBox();
            this.fldFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.fldServicePro = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.fldRating = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtBoxReviews = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.fldEmail);
            this.panel1.Controls.Add(this.fldPhoneNo);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblPhoneNo);
            this.panel1.Controls.Add(this.fldLastName);
            this.panel1.Controls.Add(this.fldFirstName);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 100);
            this.panel1.TabIndex = 0;
            // 
            // fldEmail
            // 
            this.fldEmail.Location = new System.Drawing.Point(277, 18);
            this.fldEmail.Name = "fldEmail";
            this.fldEmail.Size = new System.Drawing.Size(130, 20);
            this.fldEmail.TabIndex = 7;
            // 
            // fldPhoneNo
            // 
            this.fldPhoneNo.Location = new System.Drawing.Point(277, 60);
            this.fldPhoneNo.Name = "fldPhoneNo";
            this.fldPhoneNo.Size = new System.Drawing.Size(130, 20);
            this.fldPhoneNo.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(241, 21);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(211, 63);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(65, 13);
            this.lblPhoneNo.TabIndex = 4;
            this.lblPhoneNo.Text = "Phone N/O:";
            // 
            // fldLastName
            // 
            this.fldLastName.Location = new System.Drawing.Point(76, 60);
            this.fldLastName.Name = "fldLastName";
            this.fldLastName.Size = new System.Drawing.Size(129, 20);
            this.fldLastName.TabIndex = 3;
            // 
            // fldFirstName
            // 
            this.fldFirstName.Location = new System.Drawing.Point(76, 18);
            this.fldFirstName.Name = "fldFirstName";
            this.fldFirstName.Size = new System.Drawing.Size(129, 20);
            this.fldFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 63);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(10, 21);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnRight);
            this.panel2.Controls.Add(this.btnLast);
            this.panel2.Controls.Add(this.btnLeft);
            this.panel2.Controls.Add(this.btnFirst);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.fldServicePro);
            this.panel2.Controls.Add(this.lblService);
            this.panel2.Controls.Add(this.fldRating);
            this.panel2.Controls.Add(this.lblRating);
            this.panel2.Location = new System.Drawing.Point(458, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 102);
            this.panel2.TabIndex = 1;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(360, 29);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(31, 21);
            this.btnRight.TabIndex = 13;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(397, 28);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(31, 21);
            this.btnLast.TabIndex = 12;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(323, 28);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(31, 21);
            this.btnLeft.TabIndex = 11;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(286, 28);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(31, 21);
            this.btnFirst.TabIndex = 10;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(366, 56);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(41, 24);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(303, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(41, 24);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fldServicePro
            // 
            this.fldServicePro.Location = new System.Drawing.Point(157, 60);
            this.fldServicePro.Name = "fldServicePro";
            this.fldServicePro.Size = new System.Drawing.Size(130, 20);
            this.fldServicePro.TabIndex = 6;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(154, 34);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(85, 13);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service Provider";
            // 
            // fldRating
            // 
            this.fldRating.Location = new System.Drawing.Point(13, 60);
            this.fldRating.Name = "fldRating";
            this.fldRating.Size = new System.Drawing.Size(129, 20);
            this.fldRating.TabIndex = 3;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(10, 34);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 1;
            this.lblRating.Text = "Rating";
            // 
            // txtBoxReviews
            // 
            this.txtBoxReviews.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxReviews.Location = new System.Drawing.Point(15, 137);
            this.txtBoxReviews.Multiline = true;
            this.txtBoxReviews.Name = "txtBoxReviews";
            this.txtBoxReviews.Size = new System.Drawing.Size(871, 335);
            this.txtBoxReviews.TabIndex = 2;
            this.txtBoxReviews.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(901, 484);
            this.Controls.Add(this.txtBoxReviews);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrameMain";
            this.Text = "Chaotic Call Center ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox fldLastName;
        private System.Windows.Forms.TextBox fldFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox fldEmail;
        private System.Windows.Forms.TextBox fldPhoneNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox fldServicePro;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox fldRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtBoxReviews;
    }
}

