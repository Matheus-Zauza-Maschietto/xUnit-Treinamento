using ConsoleApp1.Models;
using NSubstitute;
using NSubstitute.ExceptionExtensions;

namespace Projeto_Bancario;

public class ContaTests
{
    public static IEnumerable<object[]> GetFunEClieJurTestInputs()
    {
        List<object[]> Inputs = new List<object[]>();

        Conta conta1Test1 = new Conta("44444", "44", 100, new Cliente("Ronaldo", DateTime.Parse("2004/10/02"), Sexos.MASCULINO));
        Conta conta2Test1 = new Conta("55555", "55", 200, new Cliente("Mauricio", DateTime.Parse("1971/02/10"), Sexos.MASCULINO));
        Inputs.Add(new object[] {
            conta1Test1, conta2Test1, 10, 110, 40, 240, 80, 190, 19, 32
        });

        Conta conta1Test2 = new Conta("62452", "12", 450, new Cliente("Maria", DateTime.Parse("1811/12/21"), Sexos.FEMININO));
        Conta conta2Test2 = new Conta("77777", "02", 150, new Cliente("Donald the Duck", DateTime.Parse("1534/09/09"), Sexos.INDEFINIDO));
        Inputs.Add(new object[] {
            conta1Test2, conta2Test2, 50, 500, 50, 200, 100, 600, 60, 30
        });

        return Inputs;
    }

    [Theory]
    [MemberData(nameof(GetFunEClieJurTestInputs))]
    public void CliContaTestsAll(Conta c1, Conta c2, decimal v1, decimal r1, decimal v2, decimal r2, decimal v3, decimal r3, decimal j1Test, decimal j2Test)
    {
        c2.Depositar(v2);
        c1.Sacar(v1);
        Assert.Equal(c1.Saldo, r1);
        Assert.Equal(c2.Saldo, r2);
        c1.Transferir(c2, v3);
        decimal j1 = c1.BuscarJuros();
        Assert.Equal(c1.Saldo, r3);
        Assert.Equal(j1Test, j1);
        decimal j2 = c2.BuscarJuros();
        Assert.Equal(j2Test, j2);
    }
}