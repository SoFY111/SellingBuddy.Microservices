﻿using System.Collections.Generic;

namespace CatalogService.Api.Core.Application.ViewModels
{
    public class PaginatedItemsViewModel<TEntity> where TEntity : class
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public long Count { get; set; }

        public IEnumerable<TEntity> Data { get; private set; }

        public PaginatedItemsViewModel(int pageIndex, int pageSize, long count, IEnumerable<TEntity> data)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            Count = count;
            Data = data;
        }
    }
}
