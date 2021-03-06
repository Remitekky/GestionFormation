﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionFormation
{
    public partial class AdminAddTraining : Form
    {
        public AdminAddTraining()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            DbGestionFormation db = new DbGestionFormation();
            db.InitDb();
            db.AddFormation(tbFormation.Text);
            
            this.DialogResult = DialogResult.OK;
        }
    }
}
