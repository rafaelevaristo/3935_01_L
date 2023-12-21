using Microsoft.VisualBasic;

namespace TrabalhoDois;

partial class FormPrincipal
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(2000, 1000);
        this.Text = "Gestao de gastos 0.0.1";
        this.Load += new System.EventHandler(this.FormPrincipal_Load);

        // Main menu
        this.menu = CreateMyMenuStrip();
        this.Controls.Add(menu);

        // Status
        this.status = CreateMyStatusStrip();
        this.status.Text = "Aplicação iniciada.";
        
        // Formulário Principal
        // TODO: Isto precisa de ser alterado para estar dentro de areas
        // Labels
        this.lblGastoTotal = FormControlGenerator.CreateMyLabel(12,50, "Gasto Total: Nao disponivel");
        this.lblGastoMesAtual = FormControlGenerator.CreateMyLabel(12, 80, "Gasto do Mês Atual: Nao disponivel");
        this.lblDespesaMaiorValor = FormControlGenerator.CreateMyLabel(12, 110, 800, 25, "Despesa de Maior Valor: Nao disponivel");

        // Botoes
        this.btnAdicionarDespesa = FormControlGenerator.CreateMyButton(12, 150, 250, 50, "Adicionar Despesa");
        this.btnAdicionarDespesa.Click += new System.EventHandler(this.btnAdicionarDespesa_Click);

        this.btnMostrarTabela = FormControlGenerator.CreateMyButton(12, 200, 250, 50, "Mostrar Tabela de Despesas");
        this.btnMostrarTabela.Click += new System.EventHandler(this.btnMostrarTabela_Click);

        // Isto foi passado para o for de listar despesas
        this.btnRemoverDespesa = FormControlGenerator.CreateMyButton(12, 250, 250, 50, "Remover Despesa");
        this.btnRemoverDespesa.Enabled = false;
        this.btnRemoverDespesa.Click += new System.EventHandler(this.btnRemoverDespesa_Click);

        // Adicionar controles ao formulário principal
        this.Controls.Add(this.lblGastoTotal);
        this.Controls.Add(this.lblGastoMesAtual);
        this.Controls.Add(this.lblDespesaMaiorValor);
        this.Controls.Add(this.btnAdicionarDespesa);        
        this.Controls.Add(this.btnMostrarTabela);
        this.Controls.Add(this.btnRemoverDespesa);
    }

    private MenuStrip CreateMyMenuStrip()
    {
        // Configuração do Menu

        MenuStrip newMenuStrip = new MenuStrip();

        ToolStripMenuItem menuOperacoes = new ToolStripMenuItem();
        menuOperacoes.Text = "Operacoes";
        ToolStripMenuItem menuBackup = new ToolStripMenuItem();
        menuBackup.Text = "Backup";
        menuBackup.Click += criarBackupToolStripMenuItem_Click;
        
        // Separador para a saida e ajuda
        ToolStripSeparator separatorToolStrMenu = new ToolStripSeparator();
        
        ToolStripMenuItem exitToolStrMenu = new ToolStripMenuItem();
        exitToolStrMenu.Text = "Exit";
        exitToolStrMenu.Click += fecharToolStripMenuItem_Click;


        ToolStripMenuItem helpToolStrMenu = new ToolStripMenuItem();
        helpToolStrMenu.Text = "Ajuda";
        helpToolStrMenu.Click += helpToolStripMenuItem_Click;

        menuOperacoes.DropDownItems.Add(menuBackup);
        menuOperacoes.DropDownItems.Add(separatorToolStrMenu);
        menuOperacoes.DropDownItems.Add(exitToolStrMenu);
        menuOperacoes.DropDownItems.Add(helpToolStrMenu);
        newMenuStrip.Items.Add(menuOperacoes);

        newMenuStrip.BackColor = Color.FromArgb(41, 128, 185); // Dark menu background color
        newMenuStrip.ForeColor = Color.White; // Set menu text color
        newMenuStrip.Font = new Font("Segoe UI", 8, FontStyle.Regular); // Bold font style

        return newMenuStrip;

    }

        private ToolStripStatusLabel CreateMyStatusStrip()
    {
        StatusStrip status = new StatusStrip();

        status.BackColor = Color.FromArgb(45, 62, 80); // Dark status strip background color
        status.ForeColor = Color.White; // Set status strip text color
        status.Font = new Font("Segoe UI", 9, FontStyle.Regular); // Regular font style

        ToolStripStatusLabel statusLabel = new ToolStripStatusLabel();
        status.Items.Add(statusLabel);        
        this.Controls.Add(status);
        return statusLabel;
    }

    private Label lblGastoTotal;
    private Label lblGastoMesAtual;
    private Label lblDespesaMaiorValor;
    private Button btnAdicionarDespesa;    
    private Button btnMostrarTabela;    
    private ToolStripStatusLabel status;
    private MenuStrip menu;
    private Button btnRemoverDespesa;

    #endregion
}
