﻿namespace GestionFormation
{
    partial class GuestView
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
            this.cbFormations = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFormations
            // 
            this.cbFormations.FormattingEnabled = true;
            this.cbFormations.Location = new System.Drawing.Point(289, 51);
            this.cbFormations.Name = "cbFormations";
            this.cbFormations.Size = new System.Drawing.Size(226, 24);
            this.cbFormations.TabIndex = 0;
            this.cbFormations.SelectedIndexChanged += new System.EventHandler(this.cbFormations_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formations:";
            // 
            // dgvSessions
            // 
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Location = new System.Drawing.Point(12, 154);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.RowTemplate.Height = 24;
            this.dgvSessions.Size = new System.Drawing.Size(776, 284);
            this.dgvSessions.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sessions:";
            // 
            // GuestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSessions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFormations);
            this.Name = "GuestView";
            this.Text = "Planning des formations";
            this.Load += new System.EventHandler(this.GuestView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFormations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.Label label2;
    }
}