using System.Security.Claims;

namespace Test02.Services
{
    public static class ClaimsStore
    {
        public static List<Claim> GetAllClaims()
        {
            return new List<Claim>
            {
                new Claim("Create Role", "Create Role"),
                new Claim("Edit Role", "Edit Role"),
                new Claim("Delete Role", "Delete Role"),
            };
         }
    }
}
