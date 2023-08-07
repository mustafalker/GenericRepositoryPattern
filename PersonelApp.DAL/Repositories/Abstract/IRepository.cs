using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DAL.Repositories.Abstract
{
    public interface IRepository<T> where T : class //Mecburen Class Olmalı Aslında Bazı Başka Tipler De Döndürebiliriz Ama Çoğunlukla Uygun Olmaz Şimdiye Kadar Gördüğüm Örneklerde Hiç Kullanmadım Diyebilirim 
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(int id);
        void RemoveRange(IEnumerable<T> entities);
    }
}
