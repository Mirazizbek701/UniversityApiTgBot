using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TgBotProject.Application.Interfaces;
using TgBotProject.Domain.Models;

namespace TgBotProject.Application.Services;

public class UniversityService : IUniversityService
{
    private readonly HttpClient _httpClient;
    private readonly string _url;
    public UniversityService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _url = configuration.GetSection("BaseAddress")["universityApi"];
        _httpClient.BaseAddress = new Uri($"{_url}");
    }

    public async Task<University> GetUniversities()
    {
        var response = await _httpClient.GetAsync("");
        var responseModel = await response.Content.ReadFromJsonAsync<University>();

        return responseModel;
    }

    public Task<string> GetUniversity()
    {
        throw new NotImplementedException();
    }
}
