using Microsoft.AspNetCore.Identity;

namespace NewNet8Auth.Models;

public class AppUserRole : IdentityRole
{
    //example of a custom IdentityRole with two claims
    public const string CanCreate = "CanCreate";
    public const string CanRead = "CanRead";
        
}

//a different role with different claims
public class AppUserRole2 : IdentityRole
{
    public const string CanUpdate = "CanUpdate";
    public const string CanDelete = "CanDelete";
}

//another role with all the same claims as both above
public class AppUserRole3 : IdentityRole
{
    public const string CanCreate = "CanCreate";
    public const string CanRead = "CanRead";
    public const string CanUpdate = "CanUpdate";
    public const string CanDelete = "CanDelete";
}
