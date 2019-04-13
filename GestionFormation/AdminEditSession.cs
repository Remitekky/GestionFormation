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
    public partial class AdminEditSession : Form
    {
        //
        //Properties
        //
        private Session session;


        //
        //Getters & Setters
        //
        public Session Session { get; set; }


        //
        //Builders
        //
        public AdminEditSession()
        {
            InitializeComponent();
            this.Session = null;
        }

        public AdminEditSession(Session theSession)
        {
            InitializeComponent();
            this.Session = theSession;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}