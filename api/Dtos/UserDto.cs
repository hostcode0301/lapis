using System;
using System.ComponentModel.DataAnnotations;

namespace Lapis.API.Dtos
{
    public class UserCreateDto
    {
        [Required]
        [EmailAddress]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Username must be from 6 to 100 letters")]
        public string Email { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be from 8 to 100 letters")]
        public string Password { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Name must be from 1 to 100 letters")]
        public string Name { get; set; }
    }

    public class UserReadDto
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Wallpaper { get; set; }
        public DateTime Created { get; set; }
    }

    public class UserUpdateDto
    {
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Name must be from 1 to 100 letters")]
        public string Name { get; set; }
    }

    public class UserUpdatePasswordDto
    {
        [Required]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be from 8 to 100 letters")]
        public string OldPassword { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be from 8 to 100 letters")]
        public string NewPassword { get; set; }
    }
}