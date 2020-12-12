﻿

using System.Collections.Generic;
using System.Threading.Tasks;
using Parainfo.Data.Models;
using ParaInfo.Web.ApiModels.Paraglider;

namespace Services.Services.Data.Interfaces
{
    public interface IParagliderService
    {
        public Task<Paraglider> CreateAsync(AddParagliderModel model);

        public Task<IEnumerable<Paraglider>> GetAllAsync();

        public Task<IEnumerable<Paraglider>> GetAllFilteredAsync();

        public Task<IEnumerable<Paraglider>> GetAllByBrandFilteredAsync(string brand);

        public Task<Paraglider> GetByIdAsync(string id);

        public Task<Paraglider> GetByModelAndBrandAsync(string brand, string model);

        public Task<Paraglider> GetByModelAsync(string name);

        Task<IEnumerable<Paraglider>> GetAFewOrderByViewsAsync(int count);

        public Task<Paraglider> UpdateAsync(UpdateParagliderModel model);

        public Task<Paraglider> DeleteAsync(string id);
    }
}