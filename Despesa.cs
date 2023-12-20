namespace TrabalhoDois
{
    // Classe abstrata para representar despesas
    [Serializable]
    public abstract class Despesa
    {
        private string nome;
        private decimal valor;
        private DateTime dataDespesa;

        public CategoriaDespesa Categoria;

        protected Despesa(string nome, decimal valor, DateTime dataDespesa)
        {
            Nome = nome;
            Valor = valor;
            DataDespesa = dataDespesa;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public decimal Valor {
            get { return valor; }
            set { valor = value; }        
        }
        public DateTime DataDespesa {
            get { return dataDespesa; }
            set { dataDespesa = value; }
        }
        public abstract string Tipo { get; }
        public abstract decimal CalculaDespesa();
    }


    public enum CategoriaDespesa
    {
        Outras,
        Essencial,
        Divertimento,
        Saude
    }

    // Classe para despesa fixa
    public class DespesaFixa : Despesa
    {
        public DespesaFixa(string nome, decimal valor, DateTime dataDespesa) : base(nome, valor, dataDespesa)
        {
        }

        public override string Tipo
        {
            get
            {
                return "Despesa Fixa";
            }
        }

        public override decimal CalculaDespesa()
        {
            return Valor;
        }
    }

    // Classe para despesa variável
    public class DespesaVariavel : Despesa
    {
        public DespesaVariavel(string nome, decimal valor, DateTime dataDespesa) : base(nome, valor, dataDespesa)
        {
        }

        public override string Tipo
        {
            get
            {
                return "Despesa Variável";
            }
        }

        public override decimal CalculaDespesa()
        {
            return Valor * 1.1m;
        }
    }

    // Classe para gerir despesas
    public class GestorDespesas
    {
        private List<Despesa> despesas;

        public GestorDespesas()
        {
            despesas = new List<Despesa>();
        }

        public void AdicionarDespesa(Despesa despesa)
        {
            despesas.Add(despesa);
        }

        public void RemoverDespesa(int selecteIndex)
        {
            despesas.RemoveAt(selecteIndex);
        }

        public decimal CalcularGastoTotal()
        {
            // Isto é uma coisa da interface IEnumerable que o IList herda e que o List implementa
            // Podemos andar à volta com o ciclo for, mas depois de uma pesquisa encontrei isto do sum.
            // Estive a ver com um F11 e o que a funcao sum lá dentro faz é um for each. So um bocadinho mais complexo pq recebe uma função, mas é perceptivel.
            return despesas.Sum(d => d.CalculaDespesa());
        }

        public decimal CalcularGastoMesAtual()
        {
            // Isto é uma coisa do linq em objectos
            // Podemos por isto num array e andar à procura
            // O linq retorna uma lista e depois é com o calcular o gasto
            // Podemos andar aqui às voltas num for e ver se o mês actual é o da despesa mas isso é chato e pouco proveitoso. linq faz parte do que todos deviamos saber
            return despesas.Where(d => d.DataDespesa.Month == DateTime.Now.Month && d.DataDespesa.Year == DateTime.Now.Year).Sum(d => d.CalculaDespesa());
        }

        public Despesa ObterDespesaMaiorValor()
        {
            /* Sim sim outra vez o linq e depois retorna-se o primeiro
               Podemos andar aqui ás voltas num loop e ver qual a maior e bla e bla */
            return despesas.OrderByDescending(d => d.Valor).FirstOrDefault();
        }

        public List<Despesa> ObterTodasDespesas()
        {
            return despesas;
        }
    }

}
