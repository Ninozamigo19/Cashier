using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.Model
{
    public class SaleDetail
    {
        public int Id { get; set; }
        public Product Produk { get; set; }
        public Sale Jual { get; set; }
        public int Jumlah { get; set; }
        public decimal SubTotalHarga { get; set; }
        public User Pengguna { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<SaleDetail>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).ValueGeneratedOnAdd();
                e.Property(e => e.Jumlah).HasColumnType("int").IsRequired();
                e.Property(e => e.SubTotalHarga).HasColumnType("decimal(10,2)").IsRequired();
                e.HasOne(e => e.Produk);
                e.HasOne(e => e.Jual);
                e.HasOne(e => e.Pengguna);
            });
        }
    }
}
