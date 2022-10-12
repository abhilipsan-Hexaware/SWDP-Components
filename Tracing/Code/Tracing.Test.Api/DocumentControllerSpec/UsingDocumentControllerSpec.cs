using NSubstitute;
using Tracing.Test.Framework;
using Tracing.Api.Controllers;
using Tracing.Business.Interfaces;


namespace Tracing.Test.Api.DocumentControllerSpec
{
    public abstract class UsingDocumentControllerSpec : SpecFor<DocumentController>
    {
        protected IDocumentService _documentService;

        public override void Context()
        {
            _documentService = Substitute.For<IDocumentService>();
            subject = new DocumentController(_documentService);

        }

    }
}
