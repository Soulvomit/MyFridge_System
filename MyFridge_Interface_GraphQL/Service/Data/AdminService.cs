﻿using Microsoft.EntityFrameworkCore;
using MyFridge_Interface_GraphQL.Service.Data.Abstract;
using MyFridge_Library_Data.DataContext;
using MyFridge_Library_Data.DataModel;
using MyFridge_Library_Data.DataRepository;

namespace MyFridge_Interface_GraphQL.Service.Data
{
    public class AdminService : DataService<AdminAccountDto>
    {
        public AdminService(IDbContextFactory<ApplicationDbContext> contextFactory, ILoggerFactory logFactory)
            : base (contextFactory, logFactory)
        {
            Repository = new AdminAccountDataRepository(_contextFactory.CreateDbContext(), _log);
        }
    }
}
