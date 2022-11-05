﻿using System.ComponentModel.DataAnnotations;

namespace MLS.WebUI.Models.Identity;

public class CreateUserViewModel
{
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }
    [MaxLength(50)]
    public DateTime? BirthDate { get; set; }
    [Required]
    [MaxLength(50)]
    public string UserName { get; set; }
    [Required]
    [MaxLength(100)]
    public string Email { get; set; }
    [Required]
    [MaxLength(50)]
    public string Password { get; set; }
}
public class UpdateUserViewModel : CreateUserViewModel
{
    public int Id { get; set; }
}
