using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TgBotProject.Domain.Models;

namespace TgBotProject.Application.Interfaces;

public interface IUniversityService
{
    Task<University> GetUniversities();
    Task<string> GetUniversity();
}
