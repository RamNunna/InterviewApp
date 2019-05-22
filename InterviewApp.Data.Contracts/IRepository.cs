
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewApp.Data
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        bool Add(T input);
        T GetById(int id);
        bool Update(T input);
        bool Delete(int id);
    }
}
