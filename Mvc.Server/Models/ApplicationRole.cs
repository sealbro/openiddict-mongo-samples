using System;
using AspNetCore.Identity.MongoDbCore.Models;

namespace Mvc.Server.Models
{
    public class ApplicationRole : MongoIdentityRole<Guid>
    {
        public ApplicationRole()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {
        }
    }
}