
using System;

namespace SubTrackerTest1
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
            this.topLbl = new System.Windows.Forms.Label();
            this.subLstbx = new System.Windows.Forms.ListBox();
            this.prodLstbx = new System.Windows.Forms.ListBox();
            this.custLstbx = new System.Windows.Forms.ListBox();
            this.subBtn = new System.Windows.Forms.Button();
            this.prodBtn = new System.Windows.Forms.Button();
            this.custBtn = new System.Windows.Forms.Button();
            this.findSubBtn = new System.Windows.Forms.Button();
            this.subTxtbx = new System.Windows.Forms.TextBox();
            this.randomSubBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLbl
            // 
            this.topLbl.AutoSize = true;
            this.topLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLbl.Location = new System.Drawing.Point(387, 9);
            this.topLbl.Name = "topLbl";
            this.topLbl.Size = new System.Drawing.Size(308, 33);
            this.topLbl.TabIndex = 0;
            this.topLbl.Text = "Mr. Mixer Admin Tools";
            // 
            // subLstbx
            // 
            this.subLstbx.FormattingEnabled = true;
            this.subLstbx.Location = new System.Drawing.Point(12, 309);
            this.subLstbx.Name = "subLstbx";
            this.subLstbx.Size = new System.Drawing.Size(293, 264);
            this.subLstbx.TabIndex = 1;
            // 
            // prodLstbx
            // 
            this.prodLstbx.FormattingEnabled = true;
            this.prodLstbx.Location = new System.Drawing.Point(402, 309);
            this.prodLstbx.Name = "prodLstbx";
            this.prodLstbx.Size = new System.Drawing.Size(293, 264);
            this.prodLstbx.TabIndex = 2;
            this.prodLstbx.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // custLstbx
            // 
            this.custLstbx.FormattingEnabled = true;
            this.custLstbx.Location = new System.Drawing.Point(790, 309);
            this.custLstbx.Name = "custLstbx";
            this.custLstbx.Size = new System.Drawing.Size(293, 264);
            this.custLstbx.TabIndex = 3;
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(181, 269);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(124, 34);
            this.subBtn.TabIndex = 4;
            this.subBtn.Text = "Subscribers";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // prodBtn
            // 
            this.prodBtn.Location = new System.Drawing.Point(571, 269);
            this.prodBtn.Name = "prodBtn";
            this.prodBtn.Size = new System.Drawing.Size(124, 34);
            this.prodBtn.TabIndex = 5;
            this.prodBtn.Text = "Products";
            this.prodBtn.UseVisualStyleBackColor = true;
            this.prodBtn.Click += new System.EventHandler(this.prodBtn_Click);
            // 
            // custBtn
            // 
            this.custBtn.Location = new System.Drawing.Point(959, 269);
            this.custBtn.Name = "custBtn";
            this.custBtn.Size = new System.Drawing.Size(124, 34);
            this.custBtn.TabIndex = 6;
            this.custBtn.Text = "Customers";
            this.custBtn.UseVisualStyleBackColor = true;
            this.custBtn.Click += new System.EventHandler(this.custBtn_Click);
            // 
            // findSubBtn
            // 
            this.findSubBtn.Location = new System.Drawing.Point(13, 164);
            this.findSubBtn.Name = "findSubBtn";
            this.findSubBtn.Size = new System.Drawing.Size(124, 36);
            this.findSubBtn.TabIndex = 7;
            this.findSubBtn.Text = "Find Subscribers";
            this.findSubBtn.UseVisualStyleBackColor = true;
            // 
            // subTxtbx
            // 
            this.subTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTxtbx.Location = new System.Drawing.Point(179, 174);
            this.subTxtbx.Name = "subTxtbx";
            this.subTxtbx.Size = new System.Drawing.Size(138, 26);
            this.subTxtbx.TabIndex = 8;
            // 
            // randomSubBtn
            // 
            this.randomSubBtn.Location = new System.Drawing.Point(13, 269);
            this.randomSubBtn.Name = "randomSubBtn";
            this.randomSubBtn.Size = new System.Drawing.Size(124, 34);
            this.randomSubBtn.TabIndex = 9;
            this.randomSubBtn.Text = "Get Random";
            this.randomSubBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 585);
            this.Controls.Add(this.randomSubBtn);
            this.Controls.Add(this.subTxtbx);
            this.Controls.Add(this.findSubBtn);
            this.Controls.Add(this.custBtn);
            this.Controls.Add(this.prodBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.custLstbx);
            this.Controls.Add(this.prodLstbx);
            this.Controls.Add(this.subLstbx);
            this.Controls.Add(this.topLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLbl;
        private System.Windows.Forms.ListBox subLstbx;
        private System.Windows.Forms.ListBox prodLstbx;
        private System.Windows.Forms.ListBox custLstbx;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button prodBtn;
        private System.Windows.Forms.Button custBtn;
        private System.Windows.Forms.Button findSubBtn;
        private System.Windows.Forms.TextBox subTxtbx;
        private System.Windows.Forms.Button randomSubBtn;
    }
}

