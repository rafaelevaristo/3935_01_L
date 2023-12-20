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
    }

    // Implementar construtores, inicializações e outros métodos necessários
    public void AtualizarDadosEstatisticos()
    {

        var gestorDespesas = Program.gestorDespesas;

        var gastoTotal = gestorDespesas.CalcularGastoTotal();
        var gastoMesAtual = gestorDespesas.CalcularGastoMesAtual();
        var despesaMaiorValor = gestorDespesas.ObterDespesaMaiorValor();


        this.lblGastoTotal.Text = $"Gasto Total: {gastoTotal}";
        this.lblGastoMesAtual.Text = $"Gasto do Mês Atual: {gastoMesAtual}";
        this.lblDespesaMaiorValor.Text = $"Despesa de Maior Valor: Descricao despesa {despesaMaiorValor.Nome} : Valor despesa : {despesaMaiorValor.CalculaDespesa()}  || Data despesa {despesaMaiorValor.DataDespesa} ";

        // Atualizar os dados na interface
        // MessageBox.Show("A actualizar dados do formulario principal");
        this.status.Text = "A actualizar dados do formulario principal";
        this.status.Text = $"Dados actualizados às {DateTime.Now}";



    }

    private void btnAdicionarDespesa_Click(object sender, EventArgs e)
    {
        // Abrir AdicionarDespesa para adicionar despesa
        // Atualizar totais dados apos adicionar despesa

        this.status.Text = "Adicionar despesa";

        childFormAdifionarDespesa.ShowDialog();


    }

    // Isto foi movido
    //private void btnRemoverDespesa_Click(object sender, EventArgs e)
    //{
    //    // Verificar se Form3 está aberto e remover despesa selecionada
    //    // Atualizar dados estatísticos após remover despesa

    //    throw new NotImplementedException();
    //}

    private void btnMostrarTabela_Click(object sender, EventArgs e)
    {
        // Abrir MostrarTabela para mostrar tabela de despesas

        this.status.Text = "Listar despesas";

        this.childFormMostrarTabela.Show();
    }


    private void criarBackupToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Criar backup", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
