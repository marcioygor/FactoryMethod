
namespace ApiWithFactoryMethod.Product;

public abstract class ContaBancaria
{
    public abstract string NomeAgencia { get; set; }
    public abstract string NumeroDaConta { get; set; }
    public abstract string DigitoDaConta { get; set; }
    public abstract string TipoConta { get; }
}


//Conta corrente.
//Conta poupança.
//Conta de pagamento.
//Conta salário.