

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

            int colUmPosition = 12;
            int colDoisPosition = 300;
            int rowSpace = 50;
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FormAdicionarDespesa";
            
            // Botoes
            this.btnFecharForm = FormControlGenerator.CreateMyButton(12, rowSpace * 5, 250, 50, "Cancelar");
            this.btnFecharForm.Click += new System.EventHandler(this.btnFecharForm_Click);

            this.btnSalvarDespesa = FormControlGenerator.CreateMyButton(300, rowSpace * 5, 250, 50, "Salvar");
            this.btnSalvarDespesa.Click += new System.EventHandler(this.btnSalvarDespesa_Click);

            // Campos tabela
            this.lblValorDespesa = FormControlGenerator.CreateMyLabel(colUmPosition, rowSpace, "Valor despesa");
            this.tbValorDespesa = FormControlGenerator.CreateMyTextBox(colDoisPosition, rowSpace);
            this.errorProviderForm = new ErrorProvider();
            this.errorProviderForm.BlinkStyle = ErrorBlinkStyle.NeverBlink;


            this.lblDataDespesa = FormControlGenerator.CreateMyLabel(colUmPosition, rowSpace * 2, "Data da despesa");
            this.tbDataDespesa = new DateTimePicker();
            this.tbDataDespesa.Location = new System.Drawing.Point(colDoisPosition, rowSpace * 2);
            this.tbDataDespesa.Size = new System.Drawing.Size(150, 25);
            // Configurar o formato da data
            this.tbDataDespesa.Format = DateTimePickerFormat.Short;

            this.lblCategoriaDespesa = FormControlGenerator.CreateMyLabel(colUmPosition, rowSpace * 3, "Categoria da despesa");
            this.tbCategoriaDespesa = FormControlGenerator.CreateMyComboBox(colDoisPosition, rowSpace * 3, new string[] { "Variavel", "Fixa" });
            
            this.lblNomeDespesa = FormControlGenerator.CreateMyLabel(colUmPosition, rowSpace * 4, "Descrição Despesa");            
            this.tbNomeDespesa = FormControlGenerator.CreateMyTextBox(colDoisPosition, rowSpace * 4);
            


            // Adicionar controles ao formulário principal
            this.Controls.Add(this.lblCategoriaDespesa);
            this.Controls.Add(this.lblDataDespesa);
            this.Controls.Add(this.lblNomeDespesa);
            this.Controls.Add(this.lblValorDespesa);
            this.Controls.Add(this.btnFecharForm);
            this.Controls.Add(this.btnSalvarDespesa);
            this.Controls.Add(this.tbNomeDespesa);
            this.Controls.Add(this.tbValorDespesa);
            this.Controls.Add(this.tbDataDespesa);
            this.Controls.Add(this.tbCategoriaDespesa);
        }

        private Button btnFecharForm, btnSalvarDespesa;
        private TextBox tbValorDespesa, tbNomeDespesa;
        DateTimePicker tbDataDespesa;
        private ComboBox tbCategoriaDespesa;
        private Label lblCategoriaDespesa, lblDataDespesa, lblValorDespesa, lblNomeDespesa;
        private ErrorProvider errorProviderForm;



        #endregion
    }
}