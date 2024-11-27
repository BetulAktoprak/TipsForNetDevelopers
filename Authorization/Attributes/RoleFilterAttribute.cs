using Microsoft.AspNetCore.Mvc;

namespace Authorization.Attributes;

public class RoleFilterAttribute : TypeFilterAttribute
{
    public RoleFilterAttribute(string role) : base(typeof(RoleAttribute))
    {
        Arguments = new object[] { role };
    }
}
