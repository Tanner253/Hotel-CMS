﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace AsyncInn.Data
{
    public class AsyncdbContext : DbContext
    {
        public AsyncdbContext(DbContextOptions<AsyncdbContext> options) : base(options)
        {


        }
        //public DbSet<MODELNAME> TABLENAME { get; set; }

    }
}
