﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafos
{
    public partial class Vertice : Form
    {
        public bool control;
        public string dato;
   
        public Vertice()
        {
            InitializeComponent();
            
            control = false;
            dato = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string valorV = txtVertice.Text.Trim();
         
            if(valorV==""||valorV==" ")
                MessageBox.Show("Debes ingresar un valor","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            else
            {
                control = true;
                Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            control = false;
            Hide();
        }

        private void Vertice_Load(object sender, EventArgs e)
        {
            txtVertice.Focus();

        }
  

        private void Vertice_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Vertice_Shown(object sender, EventArgs e)
        {
            txtVertice.Clear();
            txtVertice.Focus();

        }

        private void Vertice_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnAceptar_Click(null, null);
            }
        }
    }
}
