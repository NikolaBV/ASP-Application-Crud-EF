using Microsoft.AspNetCore.Identity;

namespace Borsa_Nikola12a.Data
{
    public class Customer: IdentityUser
    {
        public string FullName { get; set; }
        ICollection<Order>? Orders { get; set; }
    }
}
