using NSubstitute;
using Logging.Test.Framework;
using Logging.Api.Controllers;
using Logging.Business.Interfaces;


namespace Logging.Test.Api.DocumentControllerSpec
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
