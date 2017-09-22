using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment_2.Models
{
    public class Context:DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}