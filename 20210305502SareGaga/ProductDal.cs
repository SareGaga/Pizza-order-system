using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210305502SareGaga
{
    public class ProductDal
    {

        public List<Product> GetAll()
        {
            using (PizzasGoContext context = new PizzasGoContext())

            {
                return context.Products.ToList(); // veritabanındaki tabloya erişiyor.
            }
        }

        public List<Product> GetByName(String key)
        {
            using (PizzasGoContext context = new PizzasGoContext())

            {
                return context.Products.Where(p=>p.PizzaName.Contains(key)).ToList(); // veritabanına sorgu atıyor.Sadece ihtiyacımı olan datayı search yapıyor.
            }
        }

        // sorun burada referans almıyor.
        public void Update(Product product) // veritabanına güncelleme yapıyor
        {
            using (PizzasGoContext context = new PizzasGoContext())
            {
                var entity = context.Entry(product); // gönderilen productı veritabanındaki product ile eşleştiriyor.
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }

        }
    }
}
 