using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountNumber.UnitTest.Mock
{
    class MockCrmService : IOrganizationService
    {
        public void Associate(string entityName, Guid entityId, Relationship relationship, EntityReferenceCollection relatedEntities)
        {
            throw new NotImplementedException();
        }

        public Guid Create(Entity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(string entityName, Guid id)
        {
            throw new NotImplementedException();
        }

        public void Disassociate(string entityName, Guid entityId, Relationship relationship, EntityReferenceCollection relatedEntities)
        {
            throw new NotImplementedException();
        }

        public OrganizationResponse Execute(OrganizationRequest request)
        {
            throw new NotImplementedException();
        }

        public Entity Retrieve(string entityName, Guid id, Microsoft.Xrm.Sdk.Query.ColumnSet columnSet)
        {
            throw new NotImplementedException();
        }

        public EntityCollection RetrieveMultiple(Microsoft.Xrm.Sdk.Query.QueryBase query)
        {
            EntityCollection collection = new EntityCollection();
            AliasedValue maxAccountNumber = new AliasedValue("account", "intnumber_max", 10);
            Entity entity = new Entity();
            entity.Attributes.Add("intnumber_max", maxAccountNumber);
            collection.Entities.Add(entity);

            return collection;
        }

        public void Update(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
