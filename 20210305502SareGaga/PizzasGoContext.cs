using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace _20210305502SareGaga
{
    public class PizzasGoContext : DbContext // Db context kütüphanesinden inheritance yaptık
    {
       
            public DbSet<Product> Products { get; set; } // tablolarda Productsı arıyor  veritabanı tablolarda products olmalı

        }
    }

