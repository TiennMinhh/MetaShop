﻿using MetaShop.Common;
using MetaShop.Common.Dtos;

namespace MetaShop.Business.Interfaces
{
    public interface IAssetService
    {
        Task<IEnumerable<AssetDto>> GetAllAsync();

        Task<PagedResponseModel<AssetDto>> PagedQueryAsync(string filename, int page, int limit);

        Task<AssetDto> GetByIdAsync(Guid id);

        Task<AssetDto> GetByNameAsync(string filename);

        Task<AssetDto> AddAsync(AssetDto assetDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(AssetDto assetDto);
    }
}
