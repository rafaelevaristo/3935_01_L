namespace TrabalhoDois;

public partial class FormPrincipal : Form
{
    private FormAdicionarDespesa childFormAdifionarDespesa;
    private FormMostrarTabela childFormMostrarTabela;

    public FormPrincipal()
    {
        InitializeComponent();
        this.childFormAdifionarDespesa = new FormAdicionarDespesa(this);
        this.childFormMostrarTabela = new FormMostrarTabela(this);
        Program.gestorDespesas.SaveBackUp();

    }

    // Implementar construtores, inicializa��es e outros m�todos necess�rios
    public void AtualizarDadosEstatisticos()
    {

        var gestorDespesas = Program.gestorDespesas;

        var gastoTotal = gestorDespesas.CalcularGastoTotal();
        var gastoMesAtual = gestorDespesas.CalcularGastoMesAtual();
        var despesaMaiorValor = gestorDespesas.ObterDespesaMaiorValor();

        this.lblGastoTotal.Text = $"Gasto Total:{String.Format("{0:0.00}", gastoTotal)} EUR ";
        this.lblGastoMesAtual.Text = $"Gasto do M�s Atual: {String.Format("{0:0.00}", gastoMesAtual)} EUR";
        this.lblDespesaMaiorValor.Text = $"Despesa de Maior Valor: Descricao despesa {despesaMaiorValor.Nome} : Valor despesa : {String.Format("{0:0.00}", despesaMaiorValor.CalculaDespesa())} EUR   || Data despesa {despesaMaiorValor.DataDespesa} ";

        // Atualizar os dados na interface
        // MessageBox.Show("A actualizar dados do formulario principal");
        this.status.Text = "A actualizar dados do formulario principal";
        this.status.Text = $"Dados actualizados �s {DateTime.Now}";
    }

    public void ActivarControlosDeRemover() {
        this.btnRemoverDespesa.Enabled = true;
    }

    public void DesactivarControlosDeRemover() {
        this.btnRemoverDespesa.Enabled = false;
    }

    private void btnAdicionarDespesa_Click(object sender, EventArgs e)
    {
        // Abrir AdicionarDespesa para adicionar despesa
        // Atualizar totais dados apos adicionar despesa

        this.status.Text = "Adicionar despesa";

        childFormAdifionarDespesa.ShowDialog();


    }

    // Isto foi movido
    private void btnRemoverDespesa_Click(object sender, EventArgs e)
    {
        // Verificar se o tem uma row selecionada
        // Atualizar dados estat�sticos ap�s remover despesa
        this.childFormMostrarTabela.RemoverDespesa();
    }

    private void btnMostrarTabela_Click(object sender, EventArgs e)
    {
        // Abrir MostrarTabela para mostrar tabela de despesas

        this.status.Text = "Listar despesas";

        this.childFormMostrarTabela.Show();
    }


    private void criarBackupToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (Program.gestorDespesas.SaveBackUp())
        {
            MessageBox.Show("Backup criado com sucesso", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Falhou o backup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        AtualizarDadosEstatisticos();
    }

    private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Vamos fechar a aplicacao", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }

    private void helpToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Pode adicionar listar ou remover despesas. Para tal basta usar os botoes correspondetes. Para remover uma despesa clique na despesa e click no botao apagar.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.status.Text = "Ajuda";
    }    
}
