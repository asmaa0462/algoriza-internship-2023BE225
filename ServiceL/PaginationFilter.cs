using Domain;
using ServiceL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceL
{
    public class PaginationFilter
    {
        public PaginationFilter()
        {
            PageSize = 10;
            PageNumber = 1;
        }
        public PaginationFilter(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
        public PaginationFilter(int pageNumber, int pageSize, string search)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            Search = search;
        }
        public PaginationFilter(int pageNumber, int pageSize, DateTime date)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            Date = date;
        }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public DateTime Date { get; set; }
        public string Search { get; set; }

    }
}
