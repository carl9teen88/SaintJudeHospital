using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Mediators.Queries.ResponseModel
{
    public class QueryDefaultResultModel<T>
    {
        public QueryDefaultResultModel(T data, string errorMessage)
        {
            ErrorMessage = errorMessage;
            Data = data;
        }

        public bool Success
        {
            get
            {
                return string.IsNullOrEmpty(ErrorMessage);
            }
        }

        public string ErrorMessage { set; get; }

        public T Data { set; get; }
    }
}
