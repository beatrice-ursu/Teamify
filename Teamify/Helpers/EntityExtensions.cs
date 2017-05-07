﻿using System;
using Teamify.DL.Entities;

namespace Teamify.Helpers
{
    public static class EntityExtensions
    {
        public static void AddAudit(this Entity entity, ApplicationUser createdBy)
        {
            entity.CreatedOn = entity.UpdatedOn = DateTime.UtcNow;
            entity.CreatedBy = entity.UpdatedBy = createdBy;
        }

        public static void UpdateAudit(this Entity entity, ApplicationUser updatedBy)
        {
            entity.UpdatedOn = DateTime.UtcNow;
            entity.UpdatedBy = updatedBy;
        }
    }
}