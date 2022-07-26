using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace GameLibrary.Data
{
    public class GameLibraryDbContext : DbContext
    {
        public GameLibraryDbContext (DbContextOptions<GameLibraryDbContext> options) : base(options)
        {

        }

        public DbSet<Games> Games { get; set; }
    }
}