namespace TrabalhoDois;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        seedData();
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new FormPrincipal());
    }

    static private void seedData() {

        Despesa despesaUm = new DespesaFixa("Netflix",12, DateTime.Now);
        Despesa despesaDois = new DespesaVariavel("Cinema", 24, DateTime.Now);
        Despesa despesaTres = new DespesaVariavel("Prenda para o formador", 5, DateTime.Now); // A malta é forreta :)
        Despesa despesaQuatro = new DespesaFixa("Luz", 90, DateTime.Now);

        gestorDespesas.AdicionarDespesa(despesaUm);
        gestorDespesas.AdicionarDespesa(despesaDois);
        gestorDespesas.AdicionarDespesa(despesaTres);
        gestorDespesas.AdicionarDespesa(despesaQuatro);

    }

    public static GestorDespesas gestorDespesas = new GestorDespesas();

}