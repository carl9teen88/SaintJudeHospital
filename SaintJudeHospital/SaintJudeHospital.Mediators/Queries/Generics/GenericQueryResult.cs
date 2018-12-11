using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Mediators.Queries.Generics
{
    public class GenericQueryResult
    {
        public int Id { set; get; }
        public string Name { set; get; }
    }

    public class GenericQuerySingleResult
    {
        public GenericQueryResult Generic { set; get; }
        public bool IsSuccess {
            get
            {
                return this.Generic == null;
            }
        }
    }

    public class GenericQueryItemsResult
    {
        public IList<GenericQueryResult> Generics { set; get; }
        public int Page { set; get; }
        public int TotalPage { set; get; }
        public int Rows { set; get; }
    }
}
