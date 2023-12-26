using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoDois
{
    public partial class FormAdicionarDespesa : Form
    {

        private FormPrincipal formPrincipal;
        public FormAdicionarDespesa(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal; 
        }


        private void btnFecharForm_Click(object sender, EventArgs e)
        {
            formPrincipal.AtualizarDadosEstatisticos();

            // Fechar o form
            this.Close();
        }


        private void btnSalvarDespesa_Click(object sender, EventArgs e)
        {
            decimal valorDespesa; 
            Despesa novaDespesa;
            
            if (!decimal.TryParse(this.tbValorDespesa.Text, out valorDespesa))
            {

                this.errorProviderForm.SetError(this.tbValorDespesa, "Introduz um valor valido");
                
                return;
            }


            var categoriaDespesa = (String)this.tbCategoriaDespesa.SelectedItem;
            
            DateTime dataDespesa;

            try
            {
                //dataDespesa = DateTime.ParseExact(this.tbDataDespesa.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dataDespesa = this.tbDataDespesa.Value;
            }
            catch (Exception)
            {
                this.errorProviderForm.SetError(this.tbDataDespesa, $"Verifique o formato: {this.tbDataDespesa.Text}");
                return;
            }
                        
            var nomeDespesa = this.tbNomeDespesa.Text;

            if (string.IsNullOrEmpty(nomeDespesa))
            {
                this.errorProviderForm.SetError(this.tbNomeDespesa, "Campo obrigatório");
                return;
            }

            if ( categoriaDespesa.ToUpper() == "FIXA")
            {
                novaDespesa = new DespesaFixa(nomeDespesa, valorDespesa, dataDespesa);
            }
            else
            {
                novaDespesa = new DespesaVariavel(nomeDespesa, valorDespesa, dataDespesa);
            }

            MessageBox.Show($"Salvar despesa. A opção escolhita na combo é: {categoriaDespesa}  | o valor despesa é: {valorDespesa}  | a data despesa é: {dataDespesa} ");

            Program.gestorDespesas.AdicionarDespesa(novaDespesa);
            
            formPrincipal.AtualizarDadosEstatisticos();

        }

    }
}
