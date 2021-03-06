﻿using DemoApp.Linq2DbRepository.Entity;
using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Linq2DbRepository.DataContext
{
    public class DatabaseContext : DataConnection, IUnitOfWork
    {

        public DatabaseContext()
        {

        }

        public DatabaseContext(string configuration)
            : base(ConfigurationManager.ConnectionStrings["northwind-local"].Name)
		{
			
		}

        public ITable<Category> Categories { get { return GetEntity<Category>(); } }

        public ITable<Product> Products { get { return GetEntity<Product>(); } }

        public ITable<Supplier> Suppliers { get { return GetEntity<Supplier>(); } }


        public int Save()
        {
            return this.Save();
        }

        public ITable<TEntity> GetEntity<TEntity>() where TEntity : class
        {
            return this.GetTable<TEntity>();
        }
    }
}
