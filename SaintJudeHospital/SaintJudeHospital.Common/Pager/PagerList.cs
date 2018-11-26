using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaintJudeHospital.Common
{
    public static class QueryableExtensions
    {
        public static IPagerList<T> GetData<T> (this IQueryable<T> instance, int page, int rows)
        {
            return new PagerList<T>(instance, page, rows);
        }
    }

    public interface IPagerList<out T> : IEnumerable<T>
    {
        int TotalPage { set; get; }
        int TotalRecords { set; get; }
        int Rows { set; get; }
        int Page { set; get; }
    }

    public class PagerList<T> : IPagerList<T>
    {
        private readonly IEnumerable<T> _pagedData;

        public PagerList(IQueryable<T> data, int page, int rows)
        {
            this.Rows = rows;

            int skip = (page - 1) * rows;

            int totalRecords = data.Count();

            this.Page = page;

            this.TotalRecords = totalRecords;

            this.TotalPage = (int)System.Math.Ceiling(((decimal)totalRecords / rows));

            this._pagedData = data.Skip(skip).Take(rows).ToList();
        }

        public int TotalPage { get; set; }
        public int TotalRecords { get; set; }
        public int Rows { get; set; }
        public int Page { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            return _pagedData.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
