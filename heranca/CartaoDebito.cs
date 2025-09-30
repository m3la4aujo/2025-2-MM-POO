public class CartaoDebito
{
    public CartaoDebito()
    {
        Bandeira = BandeiraCartao.Mastercard;

    }
    public string Numero { get; set; }
    public BandeiraCartao Bandeira { get; set; }
    public DateTime Vencimento { get; set; }
    public string Portador { get; set; }
    public string Cvv { get; set; }    

    }


    public enum BandeiraCartao //enum é uma lista de opções que pode utilizar. 
{
    Visa,
    Mastercard,
    Amex,
    Elo
}

