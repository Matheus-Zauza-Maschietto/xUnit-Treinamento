using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Bancario;

public class FuncionarioTests
{
    private IEnumerable<object[]> GetFunEClieJurTestInputs()
    {
        List<object[]> Inputs = new List<object[]>();
        // Test 1
        Cliente cliente1 = new Cliente("Cli1", DateTime.Parse("2004/10/10"), Sexos.MASCULINO);
        new Conta("44444", "44", 1000, cliente1);
        new Conta("55555", "55", 2000, cliente1);

        // Test 2
        Cliente cliente2 = new Cliente("Cli1", DateTime.Parse("2004/10/10"), Sexos.MASCULINO);
        new Conta("44444", "44", 2000, cliente2);
        new Conta("55555", "55", 500, cliente2);

        Cliente cliente3 = new Cliente("Cli1", DateTime.Parse("2004/10/10"), Sexos.MASCULINO);
        new Conta("44444", "44", 500, cliente3);
    }

    [Theory]
    [MemberData(nameof())]
    public void FunEClieJurTest(Cliente[] clientes, int[] vDepositos, decimal resultEspTot)
    {
        string nascli1 = "2010/02/02";
        Funcionario f1 = new Funcionario(Equipes.FINANCEIRO, "José", DateTime.Parse("2004/10/10"), Sexos.MASCULINO);
        for(int i = 0; i < clientes.Length; i++)
        {
            Assert.Equal(vDepositos[i], clientes[i].BuscarJuros());
            f1.AdicionaCliente(clientes[i]);
        }
        Assert.Equal(resultEspTot, f1.BuscarComissao());
    }
}
