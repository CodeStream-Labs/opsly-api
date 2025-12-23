using Microsoft.AspNetCore.Http;

namespace Application.Common.Exceptions
{
    public class BusinessRuleException : DomainException
    {
        public BusinessRuleException(string message) 
            : base(message, StatusCodes.Status400BadRequest)
        {
        }
    }
}
