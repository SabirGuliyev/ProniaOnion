﻿using Microsoft.EntityFrameworkCore;
using ProniaOnion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion.Persistence.Common
{
    internal static class GlobalQueryFilter
    {
        public static void ApplyFilter<T>(this ModelBuilder modelBuilder) where T : BaseEntity, new()
        {
            modelBuilder.Entity<T>().HasQueryFilter(c=>c.IsDeleted==false);   
        }

        public static void ApplyQueryFilters(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyFilter<Category>();
            modelBuilder.ApplyFilter<Product>();
            modelBuilder.ApplyFilter<Color>();

        }
    }
}
