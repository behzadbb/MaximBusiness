﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Maxim.DataLayer.Context
{
    /// <summary>
    /// More info: http://www.dotnettips.info/post/2509
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        void AddRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;
        void RemoveRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;

        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class;
        T GetShadowPropertyValue<T>(object entity, string propertyName) where T : IConvertible;
        object GetShadowPropertyValue(object entity, string propertyName);

        void ExecuteSqlCommand(string query);
        void ExecuteSqlCommand(string query, params object[] parameters);

        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}