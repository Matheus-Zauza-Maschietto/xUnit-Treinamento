using App.Models;
using App.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Endpoints;

public static class PessoaEndpoints
{
    public static void DefinirPessoaEndpoints(this WebApplication app)
    {
        app.MapGet("/pessoas/{id:int}", BuscarPessoa);
        app.MapGet("/pessoas", ListarPessoas);
        app.MapPost("/pessoas", CriarPessoa);
    }

    public static async Task<IResult> BuscarPessoa([FromRoute]int id, IPessoaService pessoaService)
    {
        Pessoa pessoa = null;
        try
        {
            pessoa = await pessoaService.BuscarPessoa(id);
        }
        catch (ArgumentException ex)
        {
            return Results.Ok(ex.Message);
        }
        catch (Exception ex)
        {
            return Results.BadRequest(ex.Message);
        }
        return Results.Ok(pessoa);
    }

    public static async Task<IResult> CriarPessoa([FromBody] Pessoa novaPessoa, IPessoaService pessoaService)
    {
        Pessoa pessoaCriada = null;
        try
        {
            pessoaCriada = await pessoaService.CriarPessoa(novaPessoa);
        }
        catch (Exception ex)
        {
            return Results.BadRequest(ex.Message);
        }
        return Results.Ok(pessoaCriada);
    }

    public static async Task<IResult> ListarPessoas(IPessoaService pessoaService)
    {
        List<Pessoa> pessoas = null;
        try
        {
            pessoas = await pessoaService.ListarPessoas();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }

        return Results.Ok(pessoas);
    }
}
