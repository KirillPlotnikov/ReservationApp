﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SemestralkaDataControl.Repo
{
    public interface IRepo<T>
    {
        int Add(T entity);
        int Add(IList<T> entities);
        T GetOne(int? id);
        List<T> GetSome(Expression<Func<T, bool>> where);
        List<T> GetAll();
        List<T> GetAll<TSortField>(Expression<Func<T, TSortField>> orderBy, bool ascending);
    }
}
