﻿namespace WebApiAdminUser.Models;

public class AdminUser
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime AddDate { get; set; }
}
