﻿namespace GestionFormation
{
    partial class AdminEditSession
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.tbTraining = new System.Windows.Forms.TextBox();
            this.lbHourBegin = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTraining = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbHourEnd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hourEnd = new System.Windows.Forms.TextBox();
            this.hourBegin = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(163, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 37);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnValidate.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.Location = new System.Drawing.Point(338, 295);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(114, 37);
            this.btnValidate.TabIndex = 16;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // tbPlace
            // 
            this.tbPlace.Location = new System.Drawing.Point(366, 53);
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(172, 22);
            this.tbPlace.TabIndex = 9;
            // 
            // tbTraining
            // 
            this.tbTraining.Enabled = false;
            this.tbTraining.Location = new System.Drawing.Point(163, 32);
            this.tbTraining.Name = "tbTraining";
            this.tbTraining.Size = new System.Drawing.Size(270, 22);
            this.tbTraining.TabIndex = 14;
            // 
            // lbHourBegin
            // 
            this.lbHourBegin.AutoSize = true;
            this.lbHourBegin.Location = new System.Drawing.Point(120, 140);
            this.lbHourBegin.Name = "lbHourBegin";
            this.lbHourBegin.Size = new System.Drawing.Size(95, 17);
            this.lbHourBegin.TabIndex = 4;
            this.lbHourBegin.Text = "Heure début :";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(21, 51);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(42, 17);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lieu:";
            // 
            // lbTraining
            // 
            this.lbTraining.AutoSize = true;
            this.lbTraining.Location = new System.Drawing.Point(220, 12);
            this.lbTraining.Name = "lbTraining";
            this.lbTraining.Size = new System.Drawing.Size(151, 17);
            this.lbTraining.TabIndex = 13;
            this.lbTraining.Text = "Libellé de la formation:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(66, 51);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(222, 22);
            this.dateTimePicker.TabIndex = 3;
            // 
            // lbHourEnd
            // 
            this.lbHourEnd.AutoSize = true;
            this.lbHourEnd.Location = new System.Drawing.Point(311, 140);
            this.lbHourEnd.Name = "lbHourEnd";
            this.lbHourEnd.Size = new System.Drawing.Size(74, 17);
            this.lbHourEnd.TabIndex = 6;
            this.lbHourEnd.Text = "Heure fin :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hourEnd);
            this.groupBox1.Controls.Add(this.hourBegin);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.lbHourEnd);
            this.groupBox1.Controls.Add(this.lbHourBegin);
            this.groupBox1.Controls.Add(this.lbDate);
            this.groupBox1.Controls.Add(this.tbPlace);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 195);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information de la session : ";
            // 
            // hourEnd
            // 
            this.hourEnd.Location = new System.Drawing.Point(391, 140);
            this.hourEnd.Name = "hourEnd";
            this.hourEnd.Size = new System.Drawing.Size(50, 22);
            this.hourEnd.TabIndex = 7;
            // 
            // hourBegin
            // 
            this.hourBegin.Location = new System.Drawing.Point(221, 140);
            this.hourBegin.Name = "hourBegin";
            this.hourBegin.Size = new System.Drawing.Size(50, 22);
            this.hourBegin.TabIndex = 5;
            // 
            // AdminEditSession
            // 
            this.AcceptButton = this.btnValidate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(596, 351);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.tbTraining);
            this.Controls.Add(this.lbTraining);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminEditSession";
            this.Text = "AdminEditSession";
            this.Load += new System.EventHandler(this.AdminEditSession_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox tbPlace;
        private System.Windows.Forms.TextBox tbTraining;
        private System.Windows.Forms.Label lbHourBegin;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTraining;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lbHourEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox hourEnd;
        private System.Windows.Forms.TextBox hourBegin;
    }
}