using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAdminUser.Models;

namespace WebApiAdminUser.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AdminUsersController : ControllerBase
{
    AdminUserDbContext db;
    public AdminUsersController()
    {
        db = new AdminUserDbContext();
    }


    [HttpGet]
    public IActionResult GetAll()
    {
        List<AdminUser> adminUsers = db.AdminUsers.ToList();

        return Ok(adminUsers);
    }


    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        AdminUser adminUser = db.AdminUsers.FirstOrDefault(x => x.AdminUserId == id);

        if (adminUser == null)
        {
            return NotFound("Böyle bir kullanıcı bulunmamaktadır.");
        }

        return Ok(adminUser);
    }


    [HttpPost]
    public IActionResult Add(AdminUser adminUser)
    {
        db.AdminUsers.Add(adminUser);
        db.SaveChanges();

        return Ok(adminUser);
    }


    [HttpPut]
    public IActionResult Update(AdminUser adminUser)
    {
        // önce güncellenecek data bulunur.
        AdminUser user = db.AdminUsers.FirstOrDefault(x => x.AdminUserId == adminUser.AdminUserId);

        user.Name = adminUser.Name;
        user.Surname = adminUser.Surname;
        user.Email = adminUser.Email;
        user.Phone = adminUser.Phone;
        user.IsDeleted = adminUser.IsDeleted;

        db.SaveChanges();
        return Ok(adminUser);
    }


    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        AdminUser adminUser = db.AdminUsers.Find(id);

        if (adminUser == null)
        {
            return NotFound("Kullanıcı bulunamadı");
        }

        db.AdminUsers.Remove(adminUser);
        db.SaveChanges();
        return Ok("İşlem başarılı");
    }
}
