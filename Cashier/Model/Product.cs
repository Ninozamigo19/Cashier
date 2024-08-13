using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public decimal Harga { get; set; }
        public int Jumlah { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<Product>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).ValueGeneratedOnAdd();
                e.Property(e => e.Nama).HasColumnType("varchar(50)").IsRequired();
                e.Property(e => e.Harga).HasColumnType("decimal(10,2)").IsRequired();
                e.Property(e => e.Jumlah).HasColumnType("int").IsRequired();
            });
        }
    }
}
