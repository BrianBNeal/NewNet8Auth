using Microsoft.AspNetCore.Identity;

namespace NewNet8Auth.Models;

public class AppUser : IdentityUser
{
    [PersonalData]
    public string Name { get; private set; }
    
    [PersonalData]
    public DateTime DOB { get; private set; }
    
    [PersonalData]
    public string Address { get; private set; }
}
