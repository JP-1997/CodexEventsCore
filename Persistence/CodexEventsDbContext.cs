using CodexEvents.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodexEvents.Persistence
{
    public class CodexEventsDbContext: DbContext
    {
        public CodexEventsDbContext(DbContextOptions<CodexEventsDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventRegistration> EventRegistrations { get; set; }
    }
}
