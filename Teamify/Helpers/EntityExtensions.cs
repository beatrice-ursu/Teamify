using System;
using Teamify.DL.Entities;

namespace Teamify.Helpers
{
    public static class EntityExtensions
    {
        public static void AddAudit(this Entity entity, User createdBy)
        {
            entity.CreatedOn = entity.UpdatedOn = DateTime.UtcNow;
            entity.CreatedById = entity.UpdatedById = createdBy.Id;
            entity.CreatedBy = entity.UpdatedBy = createdBy;
        }

        public static void UpdateAudit(this Entity entity, User updatedBy)
        {
            entity.UpdatedOn = DateTime.UtcNow;
            entity.UpdatedById = updatedBy.Id;
            entity.UpdatedBy = updatedBy;
        }
    }
}