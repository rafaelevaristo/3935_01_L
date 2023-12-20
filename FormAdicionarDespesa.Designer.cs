

namespace TrabalhoDois
{
    partial class FormAdicionarDespesa
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FormAdicionarDespesa";
            
            // Botoes
            this.btnFecharForm = FormControlGenerator.CreateMyButton(12, 150, 250, 50, "Cancelar");
            this.btnFecharForm.Click += new System.EventHandler(this.btnFecharForm_Click);

            this.btnSalvarDespesa = FormControlGenerator.CreateMyButton(300, 150, 250, 50, "Salvar");
            this.btnSalvarDespesa.Click += new System.EventHandler(this.btnSalvarDespesa_Click);

            // Campos tabela
            this.tbValorDespesa = FormControlGenerator.CreateMyTextBox(12, 10);
            this.lblValorDespesa = FormControlGenerator.CreateMyLabel(12, 10, "Valor despesa");

            //this.tbDataDespesa= FormControlGenerator.CreateMyTextBox(12, 50);
            this.lblDataDespesa = FormControlGenerator.CreateMyLabel(12, 10, "Data da despesa");

            this.tbDataDespesa = new DateTimePicker();
            this.tbDataDespesa.Location = new System.Drawing.Point(12, 50);
            this.tbDataDespesa.Size = new System.Drawing.Size(150, 25);
            // Configurar o formato da data
            this.tbDataDespesa.Format = DateTimePickerFormat.Short;

            this.tbCategoriaDespesa = FormControlGenerator.CreateMyComboBox(12, 100, new string[] { "Variavel", "Fixa" });
            this.lblCategoriaDespesa = FormControlGenerator.CreateMyLabel(12, 10, "Categoria da despesa");

            // Adicionar controles ao formulário principal
            this.Controls.Add(this.btnFecharForm);
            this.Controls.Add(this.btnSalvarDespesa);
            this.Controls.Add(this.tbValorDespesa);
            this.Controls.Add(this.tbDataDespesa);
            this.Controls.Add(this.tbCategoriaDespesa);
        }

        private Button btnFecharForm, btnSalvarDespesa;
        private TextBox tbValorDespesa;

        DateTimePicker tbDataDespesa;
        private ComboBox tbCategoriaDespesa;
        private Label lblCategoriaDespesa, lblDataDespesa, lblValorDespesa;

        #endregion
    }
}