using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Level { get; set; }
        public string No_Telp { get; set; }
        public string Alamat { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public static void CreateModel(ModelBuilder model)
        {
            model.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Nama).HasColumnType("varchar(50)").IsRequired();
                entity.Property(e => e.Level).HasColumnType("varchar(50)").IsRequired();
                entity.Property(e => e.No_Telp).HasColumnType("varchar(50)").IsRequired();
                entity.Property(e => e.Alamat).HasColumnType("varchar(150)").IsRequired();
                entity.Property(e => e.Username).HasColumnType("varchar(50)").IsRequired();
                entity.Property(e => e.Password).HasColumnType("varchar(50)");
            });

        }
    }
}
