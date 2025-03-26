using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Data.Data
{
    public class DAL<T> where T: class
    {
        protected readonly ParkingLotContext context;

        public DAL(ParkingLotContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> List()
        {
            return context.Set<T>().ToList();
        }

        public void AddToList(T genObject)
        {
            context.Set<T>().Add(genObject);
            context.SaveChanges();
        }

        public void updateFromList(T genObject)
        {
            context.Set<T>().Update(genObject);
            context.SaveChanges();
        }

        public void RemoveFromList(T genObject)
        {
            context.Set<T>().Remove(genObject);
            context.SaveChanges();
        }

        public T? GetBy(Func<T, bool> condition)
        {
            return context.Set<T>().FirstOrDefault(condition);
        }

        public async Task<IEnumerable<T>> ListAsyncPagination(
            int page, int pageSize, Expression<Func<T, object>>? orderBy = null, bool ascending = true )
            {
            var query = context.Set<T>().AsQueryable();

            if (orderBy != null)
            {
                query = ascending ? query.OrderBy(orderBy) : query.OrderByDescending(orderBy);
            }

            return await query.Skip((page - 1) * pageSize)
                .Take(pageSize).ToListAsync();
            }
    }
}
