﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35
{
    public partial class frmLinkLabel : Form
    {
        public frmLinkLabel()
        {
            InitializeComponent();
        }
        private void frmLinkLabel_Load(object sender, EventArgs e)
        {
            string strURL = "mailto:2111886@dlu.edu.vn";
            this.linkLabel1.Links.Add(0, strURL.Length, strURL);
            strURL = "http://www.cnttk45.net";
            this.linkLabel2.Links.Add(0, strURL.Length, strURL);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            
            if (strURL.StartsWith("mailto:"))
                Process.Start(strURL + "?subject=hello");  
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("http://www."))
                Process.Start(strURL);
        }
    }
}
