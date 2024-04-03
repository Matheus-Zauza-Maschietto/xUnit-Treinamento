using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models;

public class Conta
{
    public string Cc { get; set; }
    public string Agencia { get; set; }
    public decimal Saldo { get; private set; }
    public Cliente Dono { get; set; }

    public Conta(string cc, string agencia, decimal saldo, Cliente dono)
    {
        Cc = cc;
        Agencia = agencia;
        Saldo = saldo;
        Dono = dono;
        Dono.AdicionarConta(this);
    }

    public decimal BuscarJuros()
    {
        return Saldo / 100 * 10;
    }

    public void Depositar(decimal valor)
    {
        if(valor <= 0)
        {
            throw new Exception("Valor inválido");
        }
        this.Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor > this.Saldo)
        {
            throw new Exception("Valor inválido");
        }
        this.Saldo += valor;
    }

    public void Transferir(Conta conta, decimal valor)
    {
        if (valor > this.Saldo)
        {
            throw new Exception("Valor inválido");
        }
        this.Sacar(valor);
        conta.Depositar(valor);
    }

    public Conta()
    {
        
    }
}
