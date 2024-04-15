using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAdminUser.Models;

namespace WebApiAdminUser.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AdminUsersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        AdminUserDbContext db = new AdminUserDbContext();
    }


    [HttpGet("{id}")]
    public IActionResult Get()
    {

    }


    [HttpPost]
    public IActionResult Add()
    {

    }


    [HttpPut]
    public IActionResult Update()
    {

    }


    [HttpDelete]
    public IActionResult Delete()
    {

    }

}
