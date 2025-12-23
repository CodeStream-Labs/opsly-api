using Microsoft.AspNetCore.Http;

namespace Application.Common.Exceptions
{
    public class NotFoundException : DomainException
    {
        public NotFoundException(string message)
            : base(message, StatusCodes.Status404NotFound)
        {
        }
    }
}
