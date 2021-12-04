using System;
using System.Collections.Generic;
using RestSharp;

namespace RestRequestProject
{
    public interface IDBProcessing
    {
        void InsertIntoDB(string requestParameter, IRestResponse<List<Planet>> response);
        Planet SelectFromDB(string requestParameter);
    }
}
