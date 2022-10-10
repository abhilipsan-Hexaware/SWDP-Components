using NSubstitute;
using Logging.Test.Framework;
using Logging.Business.Services;
using Logging.Data.Interfaces;

namespace Logging.Test.Business.DocumentServiceSpec
{
    public abstract class UsingDocumentServiceSpec : SpecFor<DocumentService>
    {
        protected IDocumentRepository _documentRepository;

        public override void Context()
        {
            _documentRepository = Substitute.For<IDocumentRepository>();
            subject = new DocumentService(_documentRepository);

        }

    }
}
