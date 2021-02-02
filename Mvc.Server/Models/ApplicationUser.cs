using System;
using AspNetCore.Identity.MongoDbCore.Models;

namespace Mvc.Server.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : MongoIdentityUser<Guid>
    {
        public ApplicationUser()
        {
        }

        public ApplicationUser(string userName, string email) : base(userName, email)
        {
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}