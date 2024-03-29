using Logging.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logging.Data.Interfaces
{
    public interface IDocumentRepository : IGetAll<Document>, ISave<Document>, IUpdate<Document, string>, IDelete<string>
    {
    }
}
