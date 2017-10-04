﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIPP.Forms
{
    public partial class FormProduct : Form
    {
        DataSet DS = new DataSet();
        Product Pr = new Product();
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            var DT = Pr.LoadCombo_Department();

            while (DT.Read())
            {
                cmbDepart.Items.Add(String.Format("{0}", DT[0]));
            }
            LoadGrid();
        }

        private void dgvImage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbDepart.Text = "";

            int y;

            try
            {
                y = dgvProduct.CurrentRow.Index;

                mtbID.Text = (dgvProduct[0, y].Value).ToString();
                txtDescription.Text = (string)dgvProduct[1, y].Value;
                cmbDepart.Text = (dgvProduct[2, y].Value).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LoadGrid()
        {
            DS = Pr.LoadGrid();
            dgvProduct.DataSource = DS.Tables[0]; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(mtbID.Text == "" || txtDescription.Text == "" || cmbDepart.Text == "")
            {
                MessageBox.Show("Verifique os campos obrigatórios","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Pr.Insert(int.Parse(mtbID.Text), txtDescription.Text, int.Parse(cmbDepart.Text)) == false) { return; }

            MessageBox.Show("Salvo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtDescription.Text == "" || cmbDepart.Text == "")
            {
                MessageBox.Show("Verifique os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Pr.Update(int.Parse(mtbID.Text), txtDescription.Text, int.Parse(cmbDepart.Text)) == false) { return; }

            MessageBox.Show("Alterado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(mtbID.Text == "") 
            {
                MessageBox.Show("Verifique os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Deseja apagar este produto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Pr.Delete(int.Parse(mtbID.Text)) == false) { return; }
            }
            LoadGrid();
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            if(mtbID.Text == "")
            {
                MessageBox.Show("Insira o ID", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = Pr.LoadGrid_SearchID(int.Parse(mtbID.Text));           
            dgvProduct.DataSource = DS.Tables[0];
        }

        private void btnSearchDescription_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Insira a descrição", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = Pr.LoadGrid_SearchDesciption(txtDescription.Text);
            dgvProduct.DataSource = DS.Tables[0];
        }

        private void btnSearchDepart_Click(object sender, EventArgs e)
        {
            if (cmbDepart.Text == "")
            {
                MessageBox.Show("Selecione o Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = Pr.LoadGrid_SearchDepart(int.Parse(cmbDepart.Text));
            dgvProduct.DataSource = DS.Tables[0];
        }
    }
}