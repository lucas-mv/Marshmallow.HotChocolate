﻿using System;
using System.Linq.Expressions;

namespace Marshmallow.HotChocolate
{
    public interface IQueryProjection
    {
        Expression<Func<TEntity, dynamic>> CreateExpression<TEntity>(bool usePagination = true);

        Expression<Func<TEntity, dynamic>> CreateExpression<TEntity, TSchema>(bool usePagination = true);
    }
}
