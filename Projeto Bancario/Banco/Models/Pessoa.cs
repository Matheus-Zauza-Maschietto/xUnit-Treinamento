using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models;

public abstract class Pessoa
{
    public string Nome { get; set; }
    public DateTime Nascimento { get; set; }
    public Sexos Sexo { get; set; }


    public Pessoa(string nome, DateTime nascimento, Sexos sexo)
    {
        Nome = nome;
        Nascimento = nascimento;
        Sexo = sexo;
    }
}
