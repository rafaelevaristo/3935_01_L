﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabalhoDois
{
    public partial class FormMostrarTabela : Form
    {
        private FormPrincipal formPrincipal;
        public FormMostrarTabela(FormPrincipal formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
            InitializeDatagrid();            
        }

        private void FormMostrarTabela_Load(object sender, EventArgs e)
        {
            ReloadTable();
        }
        public void ReloadTable()
        {   
            this.dataGridView.Rows.Clear();
            foreach (var despesa in Program.gestorDespesas.ObterTodasDespesas())
            {
                //MessageBox.Show("Reload table" + despesa.Nome);

                this.dataGridView.Rows.Add(despesa.Nome, despesa.CalculaDespesa(), despesa.DataDespesa, despesa.Tipo);
            }
        }

        private void btnFecharForm_Click(object sender, EventArgs e)
        {
            formPrincipal.AtualizarDadosEstatisticos();

            // Fechar o form
            this.Hide();
        }

        private void btnRemoverDespesa_Click(object sender, EventArgs e)
        {
            // Verificar se o tem uma row selecionada
            // Atualizar dados estatísticos após remover despesa

            if (this.dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = this.dataGridView.SelectedRows[0];
                int selectedIndex = selectedRow.Index;
                Program.gestorDespesas.RemoverDespesa(selectedIndex);                
                this.ReloadTable();
            }
            else
            {
                MessageBox.Show("No row selected.");
            }

            formPrincipal.AtualizarDadosEstatisticos();
        }

        internal Boolean RemoverDespesa()
        {
            bool result = false;    

            if (this.dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = this.dataGridView.SelectedRows[0];
                int selectedIndex = selectedRow.Index;
                Program.gestorDespesas.RemoverDespesa(selectedIndex);
                this.ReloadTable();
            }
            else
            {
                MessageBox.Show("No row selected.");
            }

            formPrincipal.AtualizarDadosEstatisticos();

            return result;
        }

        // Esta é a propriedade do form que fazemos over
        protected override void OnDeactivate(EventArgs e)
        {
            this.formPrincipal.DesactivarControlosDeRemover();
        }


        protected override void OnActivated(EventArgs e)
        {
            this.formPrincipal.ActivarControlosDeRemover();
            this.ReloadTable();
        }
    }    
}
