﻿using Microsoft.EntityFrameworkCore;
using OnlineBookOrderManagementSystem.Repositories.IRepository;
using POSPharmacy.Data;

namespace OnlineBookOrderManagementSystem.Repositories.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _db;
        //public ICategoryReposiory Category { get; private set; }
        public IProductReposiory Product { get; private set; }
        public UnitOfWork(ApplicationDBContext db)
        {
            _db = db;
            //Category= new CategoryReposiory(_db);
            Product= new ProductReposiory(_db);
        }

        public async Task Save()
        {
             await _db.SaveChangesAsync();
        }
        //public void Save()
        //{
        //     _db.SaveChangesAsync();
        //}

    }
}
