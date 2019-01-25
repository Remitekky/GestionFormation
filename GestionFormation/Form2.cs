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
    public partial class Form2 : Form
    {
        DbGestionFormation db = new DbGestionFormation();
        List<Participant> ContextParticipants = new List<Participant>();
        List<Participant> ContextInscrits = new List<Participant>();

        //
        //Properties
        //
        private string nameFormation;
        private string idSession;


        //
        //Builder
        //
        public Form2(string NameFormation, string IdSession)
        {
            InitializeComponent();
            db.InitDb();
            nameFormation = NameFormation;
            idSession = IdSession;
        }



        //
        //Methods & Functions
        //
        private void Form2_Load(object sender, EventArgs e)
        {
            //DISGUSTING ! HAVE TO PASS THE ENTIRE FORMATION OBJECT !!!!!!
            //DISGUSTING ! HAVE TO PASS THE ENTIRE FORMATION OBJECT !!!!!!
            //DISGUSTING ! HAVE TO PASS THE ENTIRE FORMATION OBJECT !!!!!!
            textBoxFormation.Text = nameFormation; // !!!!!!!!!!!!!
            //DISGUSTING ! HAVE TO PASS THE ENTIRE FORMATION OBJECT !!!!!!
            //DISGUSTING ! HAVE TO PASS THE ENTIRE FORMATION OBJECT !!!!!!
            //DISGUSTING ! HAVE TO PASS THE ENTIRE FORMATION OBJECT !!!!!!


            //Fill dataGridViewParticipants with all participants
            ContextParticipants = db.GetParticipants();
            dataGridViewParticipants.DataSource = ContextParticipants;


            //Fill dataGridViewInscrits with all inscrits
            ContextInscrits = db.GetInscrits(idSession);
            dataGridViewInscrits.DataSource = ContextInscrits;
        }

        
    }
}
