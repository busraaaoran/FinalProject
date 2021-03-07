using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

//Core katmanı diğer katmanları referans almaz
namespace Core.DataAccess
{
    //generic yapımızı burada oluşturalım
    //t:class demek class= referans tipi burada
    //IEntity diyince burada t ya ientity olacak ya da ientityi implement eden bir nesne olacak(customer,product gibi)
    //new() diyince newlenebilen nesneler kabul eder oldu ve ientity interface i kabul etmiyor artık, soyutlardan sıyrıldık.

    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        //generic constraints(kısıtlamalar)
        List<T> GetAll(Expression<Func<T,bool>> filter = null);

        T Get(Expression<Func<T,bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        //List<T> GetAllByCategory(int categoryId); artık buna ihtiyaç kalmadı expressionla hallettik
    }
}
