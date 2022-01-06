using Expenses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;

namespace ling_efcore.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{

    private readonly ApplicationContext context;
    private readonly ILogger<TestController> _logger;

    public TestController(ApplicationContext context, ILogger<TestController> logger)
    {
        this.context = context;
        _logger = logger;
    }

    [HttpGet]
    [Route("users")]
    public async Task<IEnumerable<User>> GetUsers()
    {
        IEnumerable<User> users = await context.Users
                    .AsQueryable()
                    .OrderBy(u => u.Username)
                    .ToListAsync();
        return users;
    }
}