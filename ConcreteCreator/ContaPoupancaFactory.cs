using ApiWithFactoryMethod.ConcreteProduct;
using ApiWithFactoryMethod.Product;
using ApiWithFactoryMethod.Creator;

namespace ApiWithFactoryMethod.ConcreteCreator;

public class ContaPoupancaFactory : ContaFactory
{
    private string _NomeAgencia;
    private string _NumeroDaConta;
    private string _DigitoDaConta;

    public ContaPoupancaFactory(string NomeAgencia, string NumeroDaConta, string DigitoDaConta)
    {
        _NomeAgencia = NomeAgencia;
        _NumeroDaConta = NumeroDaConta;
        _DigitoDaConta = DigitoDaConta;

    }

    public override ContaBancaria BuscarContaBancaria()
    {
        return new ContaPoupanca(_NomeAgencia, _NumeroDaConta, _DigitoDaConta);
    }
}