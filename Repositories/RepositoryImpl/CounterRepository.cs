﻿using AutoMapper;
using BusinessObjecs.DTOs;
using BusinessObjecs.Models.Configured;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.RepositoryImpl
{
    public class CounterRepository : RepositoryBase<CounterEntity, CounterEntity, JeweryStoreDBContext>, ICounterRepository
    {
        private readonly JeweryStoreDBContext _Context;
        public CounterRepository(JeweryStoreDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _Context= dbContext;
        }


       /* public Task DeleteCategoryById(CategoryEntity entity, string DeletedId)
        {
            

        }*/

     
    }
}
