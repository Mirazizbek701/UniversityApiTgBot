using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TgBotProject.Application.Interfaces;
using TgBotProject.Domain.Models;

namespace TgBotProject.Application.Services;

public class UniversityService : IUniversityService
{
    public Task<University> GetUniversities()
    {
        throw new NotImplementedException();
    }

    public Task<string> GetUniversity()
    {
        throw new NotImplementedException();
    }
}
