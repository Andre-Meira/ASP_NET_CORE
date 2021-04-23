using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_CORE.Models
{
	public class Contexto : DbContext
	{

		public DbSet<User> User { get; set; }

		public Contexto(DbContextOptions<Contexto> opcoes) :base(opcoes) {}

	}
}
