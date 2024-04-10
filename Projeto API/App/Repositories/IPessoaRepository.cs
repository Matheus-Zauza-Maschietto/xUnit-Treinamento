using App.Models;

namespace App.Repositories;

public interface IPessoaRepository
{
    Task<Pessoa> BuscarPessoaPorName(int id);
    Task<List<Pessoa>> BuscarPessoas();
    Task<Pessoa> CriarPessoa(Pessoa entity);
}
