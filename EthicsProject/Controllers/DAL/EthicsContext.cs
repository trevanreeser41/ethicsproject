using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EthicsProject.Models;

namespace EthicsProject.Controllers.DAL
{
    public class EthicsContext : DbContext
    {
        public EthicsContext() : base("EthicsContext")
        {

        }
        public DbSet<Prompt> prompts { get; set; }
        public DbSet<Response> responses { get; set; }
        public DbSet<Rating> ratings { get; set; }
    }
}