using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models;

public class Funcionario : Pessoa
{
    public Equipes Equipe { get; set; }
    public List<Cliente> CarteiraClientes { get; private set; }

    public Funcionario(Equipes equipe, string nome, DateTime nascimento, Sexos sexo) : base(nome, nascimento, sexo)
    {
        Equipe = equipe;
        CarteiraClientes = new List<Cliente>();
    }

    public void AdicionaCliente(Cliente cliente)
    {
        CarteiraClientes.Add(cliente);  
    }

    public decimal BuscarComissao()
    {
        decimal comissao = 0;
        foreach (var cliente in CarteiraClientes)
        {
            foreach (var conta in cliente.Contas)
            {
                comissao += (conta.Saldo / 100);
            }
        }
        return comissao;
    }
}
