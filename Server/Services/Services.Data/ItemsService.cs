﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Data.Repository;
using Parainfo.Data.Common.Models;
using Services.Services.Data.Interfaces;


namespace Services.Services.Data
{
    public class ItemsService<T> : IItemsService<T>
    where T : BaseModel
    {
        private readonly IMongoRepository<T> mongoDb;

        public ItemsService(IMongoRepository<T> mongoDb)
        {
            this.mongoDb = mongoDb;
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            //return await mongoDb.Find(c => true).ToListAsync();
            return await mongoDb.GetAllAsync();
        }
        public async Task<T> GetByIdAsync(string id)
        {
            return await mongoDb.FindByIdAsync(id);
        }

        public async Task<T> CreateAsync(T customer)
        {
            await mongoDb.InsertOneAsync(customer);
            return customer;
        }
        public async Task UpdateAsync(T customer)
        {
            await mongoDb.ReplaceOneAsync(customer);
        }
        public async Task DeleteAsync(string id)
        {
            await mongoDb.DeleteOneAsync(c => c.Id.ToString() == id);
        }

    }
}