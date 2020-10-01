using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kosmetica.Data.Models;

namespace Kosmetica.Repository.Interface {
    public interface IBaseRepository<T> where T : class, IBase {
        /// <summary>
        /// Получить все значения модели
        /// </summary>
        /// <returns></returns>
        IQueryable<T> getAll();
        /// <summary>
        /// Получить модель по Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> getById(long id);
        /// <summary>
        /// Удалить модель
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> delete(long id);

        /// <summary>
        /// Обновить модель
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<bool> update(T model);
        /// <summary>
        /// Создать модель
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<long> create(T model);
    }
}
