using App.Models;
using App.Repositories;

namespace App.Services;

public class PessoaService : IPessoaService
{
    private readonly IPessoaRepository _pessoaRepository;
    public PessoaService(IPessoaRepository pessoaRepository)
    {
        _pessoaRepository = pessoaRepository;
    }
    public async Task<Pessoa> CriarPessoa(Pessoa entity)
    {
        Pessoa pessoa = await _pessoaRepository.CriarPessoa(entity);

        if (pessoa == null)
        {
            throw new Exception("Houve um erro ao criar a pessoa.");
        }

        return pessoa;
    }

    public async Task<Pessoa> BuscarPessoa(int id)
    {
        Pessoa pessoa = await _pessoaRepository.BuscarPessoaPorName(id);

        if (pessoa == null)
        {
            throw new ArgumentException("Pessoa não encontrada");
        }

        return pessoa;
    }

    public async Task<List<Pessoa>> ListarPessoas()
    {
        List<Pessoa> pessoas = await _pessoaRepository.BuscarPessoas();

        return pessoas;
    }
}
