using ApiWithFactoryMethod.Product;

namespace ApiWithFactoryMethod.ConcreteProduct;

public class ContaCorrente : ContaBancaria
{
    public string _NomeAgencia;
    public string _NumeroDaConta;
    public string _DigitoDaConta;
    public string _TipoConta;

    public ContaCorrente(string NomeAgencia, string NumeroDaConta, string DigitoDaConta)
    {
        _NomeAgencia = NomeAgencia;
        _NumeroDaConta = NumeroDaConta;
        _DigitoDaConta = DigitoDaConta;
        _TipoConta = "Conta Corrente";

    }

    public override string NomeAgencia
    {
        get { return _NomeAgencia; }
        set { _NomeAgencia = value; }
    }

    public override string NumeroDaConta
    {
        get { return _NumeroDaConta; }
        set { _NumeroDaConta = value; }
    }

    public override string DigitoDaConta
    {
        get { return _DigitoDaConta; }
        set { _DigitoDaConta = value; }
    }

    public override string TipoConta
    {
        get { return _TipoConta; }
    }
}