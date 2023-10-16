﻿using MetaShop.Common;
using MetaShop.Common.Dtos;

namespace MetaShop.Business.Interfaces
{
    public interface IReviewService
    {
        Task<IEnumerable<ReviewDto>> GetAllAsync();

        Task<PagedResponseModel<ReviewDto>> PagedQueryAsync(string name, int page, int limit);

        Task<ReviewDto> GetByIdAsync(Guid id);

        Task<ReviewDto> GetByNameAsync(string name);

        Task<ReviewDto> AddAsync(ReviewDto reviewDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(ReviewDto reviewDto);
    }
}
