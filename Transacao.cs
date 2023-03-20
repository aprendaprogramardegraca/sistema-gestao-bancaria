public class Transacao 
{
    public decimal Valor { get;}
    public DateTime Data { get;}
    public string Observacao { get;}

    public Transacao (decimal valor, DateTime data, string observacao)
    {
        Valor = valor; 
        Data = data;
        Observacao = observacao;
    }
}