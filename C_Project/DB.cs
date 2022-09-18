using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace C_Project
{
    public class DB : DbContext
    {
        // Контекст настроен для использования строки подключения "Model1" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "C_Project.Model1" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Model1" 
        // в файле конфигурации приложения.
        public DB()
            : base("name=DB")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<DB>());
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Order>().HasIndex(u => new { u.Customer, u.Manager }).IsUnique(true);
        //}
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Manager> Managers { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Good> Goods { get; set; }

        //public virtual DbSet<TableGood> TableGoods { get; set; }


    }

    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public double Price { get; set; }
    }
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
    public class Manager
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        private Manager manager { get; set; }       
        public string Manager { get; set; }
        private Customer customer { get; set; }
        public string Customer { get; set; }
        #region Methods
        public Manager GetManager()
        {
            return manager;
        }
        public Customer GetCustomer()
        {
            return customer;
        }
        public Manager SetManager(Manager man)
        {
            manager = man;
            return manager;
        }
        public Customer SetCustomer(Customer cust)
        {
            customer = cust;
            return customer;
        }

        public Order()
        {

        }
        public Order(Customer customer, Manager manager)
        {
            Customer = customer.Name;
            Manager = manager.Name;
            this.manager = manager;
            this.customer = customer;
        }
        #endregion
    }
    public class Good 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        private Order order { get; set; }
        public int Order { get; set; }
        
        private Product product { get; set; }
        public Product GetProduct()
        {
            return product;
        }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Count { get; set; }
        public double Sum { get; set; }
        public Good(Product product, Order order)
        {
            Product = product.Name;
            Order = order.Id;
            this.product = product;
            this.order = order;
        }
        public Good()
        {
        }
    }

    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
    
}