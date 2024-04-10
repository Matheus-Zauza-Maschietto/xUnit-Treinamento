using App.DTOs;
using App.Models;
using System;
using System.Xml.Linq;

namespace App.Repositories;

public class PessoaRepository : IPessoaRepository
{
    private readonly HttpClient _httpClient;
    public PessoaRepository(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("randomAPI");
    }
    public async Task<Pessoa> BuscarPessoaPorName(int id)
    {
        var returnItens = await _httpClient.GetFromJsonAsync<BaseModel<Pessoa>>("");
        return returnItens.results.FirstOrDefault();
    }

    public async Task<List<Pessoa>> BuscarPessoas()
    {
        var returnItens = await _httpClient.GetFromJsonAsync<BaseModel<Pessoa>>("?results=50");
        return returnItens.results;
    }

    public async Task<Pessoa> CriarPessoa(Pessoa entity)
    {
        entity.id.value = Random.Shared.Next(100000).ToString();
        return entity;
    }
}
