#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Eliezer.Models;

namespace Eliezer.Data
{
    public class EliezerContext : DbContext
    {
        public EliezerContext (DbContextOptions<EliezerContext> options)
            : base(options)
        {
        }

        public DbSet<Eliezer.Models.Class> Class { get; set; }
    }
}
