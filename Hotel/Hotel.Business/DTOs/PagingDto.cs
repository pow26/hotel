using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Business.DTOs
{
    public class PagingDto<T>
    {
        public class PagingInfo
        {
            public int PageNumber { get; set; }

            public int PageSize { get; set; }

            public long TotalRecordCount { get; set; }

        }
        public List<T> Data { get; private set; }

        public PagingInfo Paging { get; private set; }

        public PagingDto(IEnumerable<T> items, int pageNumber, int pageSize, long totalRecordCount)
        {
            Data = new List<T>(items);
            Paging = new PagingInfo
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalRecordCount = totalRecordCount
            };
        }
    }
}
