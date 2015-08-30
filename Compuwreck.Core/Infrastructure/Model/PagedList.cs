using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compuwreck.Core.Infrastructure.Model {
    public class PagedList<TEntity> {
        public PagedList(int totalRecords, int currentPage, int pageSize) {
            CurrentPage = currentPage == 0 ? 1 : currentPage;
            TotalRecords = totalRecords;
            TotalPages = (int)Math.Floor((double)(TotalRecords + pageSize - 1) / pageSize);
        }

        public int CurrentPage { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }

        public int PreviousPage {
            get { return (CurrentPage - 1 < 1) ? 1 : CurrentPage - 1; }
        }

        public int NextPage {
            get { return (CurrentPage + 1 > TotalPages) ? TotalPages : CurrentPage + 1; }
        }

        public List<TEntity> Items { get; set; }
    }
}
