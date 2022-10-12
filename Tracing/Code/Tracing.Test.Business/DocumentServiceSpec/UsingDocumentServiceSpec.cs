using NSubstitute;
using Tracing.Test.Framework;
using Tracing.Business.Services;
using Tracing.Data.Interfaces;

namespace Tracing.Test.Business.DocumentServiceSpec
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
