﻿using Microsoft.Extensions.Logging;
using MyFridge_Library_Data.Data.Repository.Base;
using MyFridge_Library_Data.Data.Repository.Interface;
using MyFridge_Library_Data.Model;

namespace MyFridge_Library_Data.Data.Repository
{
    public class IngredientAmountRepository : Repository<IngredientAmount>, IIngredientAmountRepository

    {
        public IngredientAmountRepository(ApplicationDbContext context, ILogger logger)
            : base(context, logger)
        {
        }

        public override async Task<bool> UpdateAsync(IngredientAmount updateEntity)
        {
            if (updateEntity == null) return false;

            IngredientAmount? entityInDb = await dbSet.FindAsync(updateEntity.Id);

            if (entityInDb == null) return false;

            entityInDb.Amount = updateEntity.Amount;
            entityInDb.ExpirationDate = updateEntity.ExpirationDate;

            return true;
        }
    }
}
