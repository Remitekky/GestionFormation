﻿namespace GestionFormation
{
    partial class Connection_form
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
            this.btn_co_validate = new System.Windows.Forms.Button();
            this.btn_co_cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llbForgottenPass = new System.Windows.Forms.LinkLabel();
            this.tb_co_pass = new System.Windows.Forms.TextBox();
            this.tb_co_login = new System.Windows.Forms.TextBox();
            this.lb_co_pass = new System.Windows.Forms.Label();
            this.lb_co_login = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_co_validate
            // 
            this.btn_co_validate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_co_validate.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_co_validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_co_validate.Location = new System.Drawing.Point(224, 162);
            this.btn_co_validate.Name = "btn_co_validate";
            this.btn_co_validate.Size = new System.Drawing.Size(99, 37);
            this.btn_co_validate.TabIndex = 0;
            this.btn_co_validate.Text = "Valider";
            this.btn_co_validate.UseVisualStyleBackColor = true;
            this.btn_co_validate.Click += new System.EventHandler(this.btn_co_validate_Click);
            // 
            // btn_co_cancel
            // 
            this.btn_co_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_co_cancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_co_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_co_cancel.Location = new System.Drawing.Point(93, 162);
            this.btn_co_cancel.Name = "btn_co_cancel";
            this.btn_co_cancel.Size = new System.Drawing.Size(99, 37);
            this.btn_co_cancel.TabIndex = 1;
            this.btn_co_cancel.Text = "Annuler";
            this.btn_co_cancel.UseVisualStyleBackColor = true;
            this.btn_co_cancel.Click += new System.EventHandler(this.btn_co_cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.llbForgottenPass);
            this.groupBox1.Controls.Add(this.tb_co_pass);
            this.groupBox1.Controls.Add(this.tb_co_login);
            this.groupBox1.Controls.Add(this.btn_co_validate);
            this.groupBox1.Controls.Add(this.btn_co_cancel);
            this.groupBox1.Controls.Add(this.lb_co_pass);
            this.groupBox1.Controls.Add(this.lb_co_login);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 205);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connexion";
            // 
            // llbForgottenPass
            // 
            this.llbForgottenPass.AutoSize = true;
            this.llbForgottenPass.Location = new System.Drawing.Point(243, 116);
            this.llbForgottenPass.Name = "llbForgottenPass";
            this.llbForgottenPass.Size = new System.Drawing.Size(147, 17);
            this.llbForgottenPass.TabIndex = 7;
            this.llbForgottenPass.TabStop = true;
            this.llbForgottenPass.Text = "Mot de passe oublié ?";
            // 
            // tb_co_pass
            // 
            this.tb_co_pass.Location = new System.Drawing.Point(111, 80);
            this.tb_co_pass.Name = "tb_co_pass";
            this.tb_co_pass.PasswordChar = '*';
            this.tb_co_pass.Size = new System.Drawing.Size(279, 22);
            this.tb_co_pass.TabIndex = 6;
            // 
            // tb_co_login
            // 
            this.tb_co_login.Location = new System.Drawing.Point(111, 30);
            this.tb_co_login.Name = "tb_co_login";
            this.tb_co_login.Size = new System.Drawing.Size(279, 22);
            this.tb_co_login.TabIndex = 5;
            // 
            // lb_co_pass
            // 
            this.lb_co_pass.AutoSize = true;
            this.lb_co_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_co_pass.Location = new System.Drawing.Point(2, 85);
            this.lb_co_pass.Name = "lb_co_pass";
            this.lb_co_pass.Size = new System.Drawing.Size(97, 17);
            this.lb_co_pass.TabIndex = 4;
            this.lb_co_pass.Text = "Mot de passe:";
            // 
            // lb_co_login
            // 
            this.lb_co_login.AutoSize = true;
            this.lb_co_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_co_login.Location = new System.Drawing.Point(2, 35);
            this.lb_co_login.Name = "lb_co_login";
            this.lb_co_login.Size = new System.Drawing.Size(47, 17);
            this.lb_co_login.TabIndex = 3;
            this.lb_co_login.Text = "Login:";
            // 
            // Connection_form
            // 
            this.AcceptButton = this.btn_co_validate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_co_cancel;
            this.ClientSize = new System.Drawing.Size(438, 229);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Connection_form";
            this.Text = "Connexion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_co_validate;
        private System.Windows.Forms.Button btn_co_cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_co_pass;
        private System.Windows.Forms.TextBox tb_co_login;
        private System.Windows.Forms.Label lb_co_pass;
        private System.Windows.Forms.Label lb_co_login;
        private System.Windows.Forms.LinkLabel llbForgottenPass;
    }
}