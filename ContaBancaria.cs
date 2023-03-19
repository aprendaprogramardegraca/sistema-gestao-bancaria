public class ContaBancaria
{
    public string Numero { get; }
    public string Proprietario { get; set; }
    public decimal Saldo { get; }
    private static int sementeNumeroConta = 1234567890;

    public ContaBancaria(string _proprietario, decimal  _saldoInicial)   
    {  
        if(_saldoInicial < 0)
        {
               throw new Exception("Saldo Inicial não pode ser menor que zero.");
        }
         
        //TODO: Adicionar número da agência
        this.Proprietario = _proprietario;
        this.Saldo = _saldoInicial;
        this.Numero = sementeNumeroConta.ToString();
        sementeNumeroConta++;
    }

    public void FazerDeposito(decimal amount, DateTime data, string nota)
    {
    }

    public void FazerSaque(decimal valor, DateTime data, string nota)
    {
        //TODO: PO saque não pode resultar em um saldo negativo
    }
}