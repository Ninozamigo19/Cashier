using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.Model
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime Tanggal_jual { get; set; }
        public decimal Total_Harga { get; set; }
        public Customer Pelanggan { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<Sale>(e =>
            {
                e.HasKey(e => e.Id);
                e.Property(e => e.Id).ValueGeneratedOnAdd();
                e.Property(e => e.Tanggal_jual).HasColumnType("date").IsRequired();
                e.Property(e => e.Total_Harga).HasColumnType("decimal(10,2)").IsRequired();
                e.HasOne(e => e.Pelanggan);
            });
        }
    }
}
