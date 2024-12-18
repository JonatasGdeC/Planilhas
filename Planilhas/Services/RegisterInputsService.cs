using Microsoft.EntityFrameworkCore;
using Planilhas.Data;
using Planilhas.Models;

namespace Planilhas.Services;

public class RegisterInputsService
{
  private readonly ChurchDbContext _context;

  public RegisterInputsService(ChurchDbContext context)
  {
    _context = context;
  }

  public async Task<List<RegisterInputs>> GetAllRegisterInputs()
  {
    return await _context.RegisterInputs.ToListAsync();
  }

  public async Task AddRegisterInput(RegisterInputs input)
  {
    _context.RegisterInputs.Add(input);
    await _context.SaveChangesAsync();
  }
}
