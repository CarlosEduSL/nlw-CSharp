namespace TechLibrary.Communication.Responses;

public class ResponseBooksJson
{
    public ResponsesPaginationJson Pagination { get; set; } = default!;
    public List<ResponseBookJson> Books { get; set; } = [];
}
