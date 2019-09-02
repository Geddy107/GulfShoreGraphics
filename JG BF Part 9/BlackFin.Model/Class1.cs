using System;
using Microsoft.EntityFrameworkCore;


namespace BlackFin.Model
{
    public class Class1
    {

        public class FishDump
        {
            public DbSet<Order> Orders { get; set; }
            public DbSet<OrderDetail> OrderDetails { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Product> Products { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BlackFin;Trusted_Connection=True;");
            }
        }


        public class Order
        {
            public int OrderID { get; set; }
            public string CustomerID { get; set; }
            public string OrderDate { get; set; }
            public string ShipDate { get; set; }
            public string ShipVia { get; set; }
            public string TrackingNumber { get; set; }
            public string ShippingToName { get; set; }
            public string ShipAddress { get; set; }
            public string ShipCity { get; set; }
        }

        public class OrderDetail
        {
            public int OrderID { get; set; }
            public string ProductID { get; set; }
            public float UnitPrice { get; set; }
            public int Quantity { get; set; }
            public int Discount { get; set; }


            // public int OrderID { get; set; }
            //public Order Order { get; set; }


        }

        public class Customer
        {
            public int CustomerID { get; set; }
            public string CustomerName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public int PostalCode { get; set; }
            public string Country { get; set; }
            public string PhoneNumber { get; set; }
            public string EmailAddress { get; set; }
            public string PassWord { get; set; }

        }

        public class Product
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public string CategoryID { get; set; }
            public int QuantityPerUnit { get; set; }
            public float UnitPrice { get; set; }
            public int UnitsInStock { get; set; }


        }

    }
}
