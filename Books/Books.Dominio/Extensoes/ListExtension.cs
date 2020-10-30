using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Books.Dominio.Extensoes
{
    public static class ListExtension
    {
        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> query, int? page, int? itensPerPage)
        {
            if (!page.HasValue && !itensPerPage.HasValue)
            {
                return query;
            }
            if (!itensPerPage.HasValue)
            {
                return query;
            }
            if (!page.HasValue)
            {
                return query.Take(itensPerPage.Value);
            }

            var skip = (page - 1) * itensPerPage;

            return query.Skip(skip.Value).Take(itensPerPage.Value);
        }
    }
}
