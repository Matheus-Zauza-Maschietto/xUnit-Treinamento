using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models;

public class Cliente : Pessoa
{
    public List<Conta> Contas { get; private set; }
    public Funcionario GerenteDeContas { get; set; }
    public Cliente(string nome, DateTime nascimento, Sexos sexo, Funcionario gerenteDeContas) : base(nome, nascimento, sexo)
    {
        Contas = new List<Conta>();
        GerenteDeContas = gerenteDeContas;
    }

    public void CriarConta(Conta conta)
    {
        Contas.Add(conta);
    }


    public decimal BuscarJuros()
    {
        decimal juros = 0;
        foreach (var conta in Contas)
        {
            juros += conta.BuscarJuros();
        }

        return juros;
    }
}
