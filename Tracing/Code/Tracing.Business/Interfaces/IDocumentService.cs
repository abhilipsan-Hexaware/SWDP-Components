using Tracing.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tracing.Business.Interfaces
{
    public interface IDocumentService
    {      
        IEnumerable<Document> GetAll();
        Document Save(Document classification);
        Document Update(string id, Document classification);
        bool Delete(string id);

    }
}
