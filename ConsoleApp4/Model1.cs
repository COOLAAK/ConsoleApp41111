namespace ConsoleApp4
{
    using ConsoleApp4.Bd;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ConsoleApp4.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<AbstrProduct> AbstrProduct { get; set; }
        public virtual DbSet<Adresses> Adresses { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Producer> Producer { get; set; }
        public virtual DbSet<RealProduct> RealProduct { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<User> User { get; set; }

    }
}
