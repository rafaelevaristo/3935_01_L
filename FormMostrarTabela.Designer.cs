

using Microsoft.VisualBasic.Devices;

namespace TrabalhoDois
{
    partial class FormMostrarTabela
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
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Text = "FormMostrarTabela";
            this.Load += FormMostrarTabela_Load;
            //this.OnDeactivate = new System.EventHandler( FormMostrarTabela_Load) ;
            this.ControlBox = false; // Hide control box (minimize, maximize, close buttons)
            this.MaximizeBox = false; // Disable maximize button
            this.MinimizeBox = false; // Disable minimize button

            // Botoes
            this.btnFecharForm = FormControlGenerator.CreateMyButton(110, 440, 100, 50, "Fechar Janela");
            this.btnFecharForm.Click += new System.EventHandler(this.btnFecharForm_Click);

            this.btnRemoverDespesa = FormControlGenerator.CreateMyButton(10, 440, 100, 50, "Apagar Despesa");
            this.btnRemoverDespesa.Click += new System.EventHandler(this.btnRemoverDespesa_Click);

            this.Controls.Add(this.btnRemoverDespesa);
            this.Controls.Add(this.btnFecharForm);

            setupDataGrid();
            Panel panelNome = new Panel();  
            panelNome.BackColor = System.Drawing.Color.LightGray;
            panelNome.Location = new Point(0, 0);
            panelNome.Size = new Size(800, 400);

            panelNome.Controls.Add(this.dataGridView);            
            this.Controls.Add(panelNome);

        }

        private void setupDataGrid()
        {
            // Tabela
            this.dataGridView = new DataGridView();
            // this.dataGridView.Dock = DockStyle.Fill;
            this.dataGridView.ReadOnly = true;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Location = new Point(0, 50);
            this.dataGridView.Size = new Size(450, 350);
            this.dataGridView.Dock = DockStyle.Fill;
            this.dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ScrollBars = ScrollBars.Both;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.FromArgb(52, 152, 219); // Blue background color
            headerStyle.ForeColor = Color.White; // White text color
            headerStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Bold font style
            this.dataGridView.ColumnHeadersDefaultCellStyle = headerStyle;            
        }

        private void InitializeDatagrid()
        {
            // Create columns
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Despesa";
            column1.Name = "Despesa";
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Valor";
            column2.Name = "Valor";
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.HeaderText = "Data";
            column3.Name = "Data";

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.HeaderText = "Tipo";
            column4.Name = "Tipo";

            // Add columns to DataGridView
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { column1, column2, column3, column4 });
        }

        private Button btnRemoverDespesa, btnFecharForm;
        public DataGridView dataGridView;
        #endregion
    }
}