using Microsoft.AspNetCore.Identity;

namespace Test02.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Thêm các trường tùy chỉnh nếu cần, ví dụ:
        public string FullName { get; set; }
    }
}
