﻿using MetaShop.Common;
using MetaShop.Common.Dtos;

namespace MetaShop.Business.Interfaces
{
    public interface ICartItemService
    {
        Task<IEnumerable<CartItemDto>> GetAllAsync();

        Task<PagedResponseModel<CartItemDto>> PagedQueryAsync(string name, int page, int limit);

        Task<CartItemDto> GetByIdAsync(Guid id);

        Task<CartItemDto> GetByNameAsync(string name);

        Task<CartItemDto> AddAsync(CartItemDto cartItemDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(CartItemDto cartItemDto);
    }
}
