using System.Net;

namespace TechLibrary.Exception;
 public class InvalidLoginException : TechLibraryException
{
    public InvalidLoginException() : base("E-mail ou senha envalidos") { }
    public override List<string> GetErrorMessages() => [Message];

    public override HttpStatusCode GetStatusCode() => HttpStatusCode.Unauthorized;
}
