using OnlineBookOrderManagementSystem.Repositories.IRepository;
using POSPharmacy.Data;
using POSPharmacy.Models;

namespace OnlineBookOrderManagementSystem.Repositories.Repository
{
    public class ProductReposiory : Repository<Product>, IProductReposiory
    {
        private readonly ApplicationDBContext _db;
        public ProductReposiory(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }


        public async Task Update(Product entity)
        {

            var objFromDB = _db.Product.FirstOrDefault(u => u.Id == entity.Id);
            if (objFromDB != null)
            {
                objFromDB.Name = entity.Name;
                objFromDB.Qty = entity.Qty;
                objFromDB.Price = entity.Price;
            }

            _db.Product.Update(entity);
        }

    }
}
