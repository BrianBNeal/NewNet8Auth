using Microsoft.AspNetCore.Identity;

namespace NewNet8Auth.Models;

public class AppUser : IdentityUser
{
    [PersonalData] public string Name { get; private set; } = string.Empty;

    [PersonalData] public DateTime DOB { get; private set; } = default;

    [PersonalData] public string Address { get; private set; } = string.Empty;
}
