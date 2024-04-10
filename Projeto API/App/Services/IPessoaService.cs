using App.Models;

namespace App.Services;

public interface IPessoaService
{
    Task<Pessoa> CriarPessoa(Pessoa pessoa);
    Task<Pessoa> BuscarPessoa(int id);
    Task<List<Pessoa>> ListarPessoas();
}
