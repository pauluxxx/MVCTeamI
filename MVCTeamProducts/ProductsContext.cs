using MVCTeamProducts.Models.Domain;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVCTeamProducts
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ProductsContext : DbContext
    {
        public ProductsContext()
            : base("MyContext")
        { }

        public DbSet<Product> Prodcuts { get; set; }
        public DbSet<Account> Accounts { get; set; }

    }
}