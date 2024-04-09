using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Bancario;

public class FuncionarioTests
{
    // Ideia: Bug Cliente.AdicionarConta(new Conta(...))
    //public static IEnumerable<object[]> GetFunEClieJurTestInputs()
    //{
    //    List<object[]> Inputs = new List<object[]>();

    //    // Test 1
    //    Cliente cliente1 = new Cliente("Cli1", DateTime.Parse("2004/10/10"), Sexos.MASCULINO);
    //    new Conta("44444", "44", 1000, cliente1);
    //    new Conta("55555", "55", 2000, cliente1);
    //    const decimal test1 = 300;
    //    Inputs.Add(new object[] { new Cliente[] { cliente1 }, new decimal[] { test1 }, test1 });

    //    // Test 2
    //    Cliente cliente2 = new Cliente("Cli2", DateTime.Parse("2004/10/10"), Sexos.MASCULINO);
    //    Cliente cliente4 = new Cliente("Cli4", DateTime.Parse("2004/10/10"), Sexos.MASCULINO);
    //    new Conta("44444", "44", 2000, cliente2);
    //    new Conta("55555", "55", 500, cliente2);
    //    const decimal test2 = 250;

    //    new Conta("55555", "55", 7900, cliente4);
    //    const decimal test4 = 790;
    //    Inputs.Add(new object[] { new Cliente[] { cliente2, cliente4 }, new decimal[] { test2, test4 }, test2+test4 });

    //    // Test 3
    //    Cliente cliente3 = new Cliente("Cli3", DateTime.Parse("2004/10/10"), Sexos.MASCULINO);
    //    new Conta("44444", "44", 500, cliente3);
    //    const decimal test3 = 50;
    //    Inputs.Add(new object[] { new Cliente[] { cliente3 }, new decimal[] { test3 }, test3 });

    //    return Inputs;
    //}

    //[Theory]
    //[MemberData(nameof(GetFunEClieJurTestInputs))]
    //public void FunEClieJurTest(Cliente[] clientes, decimal[] vDepositos, decimal resultEspTot)
    //{
    //    string nascli1 = "2010/02/02";
    //    Funcionario f1 = new Funcionario(Equipes.FINANCEIRO, "José", DateTime.Parse("2004/10/10"), Sexos.MASCULINO);
    //    for(int i = 0; i < clientes.Length; i++)
    //    {
    //        Assert.Equal(vDepositos[i], clientes[i].BuscarJuros());
    //        f1.AdicionaCliente(clientes[i]);
    //    }
    //    Assert.Equal(resultEspTot, f1.BuscarComissao());
    //}


}
