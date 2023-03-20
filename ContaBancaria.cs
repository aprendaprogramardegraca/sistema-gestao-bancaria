public class ContaBancaria
{
    public string Numero { get; }
    public string Proprietario { get; set; }
    private static int sementeNumeroConta = 1234567890;
    private List<Transacao> todasTransacoes = new List<Transacao>();

    public decimal Saldo 
    {
        get 
        {
        decimal _saldo = 0;
            foreach (var item in todasTransacoes)
            {   
                _saldo = item.Valor;
            }
        return _saldo;
        }
    } 

    public ContaBancaria(string _proprietario, decimal  _saldoInicial)   
    {  
        if(_saldoInicial < 0)
        {
               throw new Exception("Saldo Inicial não pode ser menor que zero.");
        }
         
        //TODO: Adicionar número da agência
        this.Proprietario = _proprietario;
        this.Numero = sementeNumeroConta.ToString();
        sementeNumeroConta++;
        FazerDeposito(_saldoInicial, DateTime.Now, "Saldo Inicial");
    }

    public void FazerDeposito(decimal valor, DateTime data, string observacao)
    {
        if (valor <= 0)
        throw new ArgumentException(nameof(valor), "Valor do deposito deve ser positivo");
    
        var deposito = new Transacao(valor, data, observacao);
        todasTransacoes.Add(deposito);
    }

    public void FazerSaque(decimal valor, DateTime data, string observacao)
    {
        //TODO: PO saque não pode resultar em um saldo negativo
    }
}