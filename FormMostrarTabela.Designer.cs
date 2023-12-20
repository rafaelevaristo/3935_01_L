

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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FormMostrarTabela";
            this.Load += FormMostrarTabela_Load;

            // Botoes
            this.btnFecharForm = FormControlGenerator.CreateMyButton(12, 150, 250, 50, "Cancelar");
            this.btnFecharForm.Click += new System.EventHandler(this.btnFecharForm_Click);

            this.btnRemoverDespesa = FormControlGenerator.CreateMyButton(12, 200, 250, 50, "Apagar Despesa");
            this.btnRemoverDespesa.Click += new System.EventHandler(this.btnRemoverDespesa_Click);


            this.Controls.Add(this.btnRemoverDespesa);
            this.Controls.Add(this.btnFecharForm);


            setupDataGrid();
            // Controlos
            this.Controls.Add(this.dataGridView);

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

            //this.dataGridView.BackgroundColor = Color.FromArgb(45, 62, 80); // Dark grid background color
            //this.dataGridView.ForeColor = Color.White; // Set grid text color
            //this.dataGridView.Font = new Font("Segoe UI", 12, FontStyle.Regular); // Regular font style

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

            //column1.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); // Blue background color
            //column2.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); // Blue background color
            //column3.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); // Blue background color
            //column1.DefaultCellStyle.ForeColor = Color.Green; // Green text color
            //column2.DefaultCellStyle.ForeColor = Color.Green; // Green text color
            //column3.DefaultCellStyle.ForeColor = Color.Green; // Green text color
            //column1.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Bold font style
            //column2.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Bold font style
            //column3.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Bold font style


            // Add columns to DataGridView
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { column1, column2, column3 });
        }

        private Button btnRemoverDespesa, btnFecharForm;
        public DataGridView dataGridView;
        #endregion
    }
}