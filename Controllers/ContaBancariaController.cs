using ApiWithFactoryMethod.ConcreteCreator;
using ApiWithFactoryMethod.Creator;
using ApiWithFactoryMethod.Product;
using Microsoft.AspNetCore.Mvc;

namespace ApiWithFactoryMethod.Controllers;

[ApiController]
[Route("contas/{TipoConta}")]
public class ContaBancariaController : ControllerBase
{
    public IActionResult BuscarContaBancaria(string TipoConta)
    {

        ContaFactory contaFactory = null;

        switch (TipoConta.ToLower())
        {
            case "conta corrente":
                contaFactory = new ContaCorrenteFactory("Santander", "09757548", "1");
                break;
            case "conta poupança":
                contaFactory = new ContaPoupancaFactory("Itaú", "08765412", "7");
                break;
            case "conta salario":
                contaFactory = new ContaSalarioFactory("Bradesco", "7654321", "9");
                break;
            default:
                return NotFound("Tipo de conta não econtrada.");
        }

        ContaBancaria contaBancaria = contaFactory.BuscarContaBancaria();

        return Ok(contaBancaria);
    }

}


