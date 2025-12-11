namespace AdminPannelLast.Services.Api.Models;

public class ApiResponse<T>
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public T? Data { get; set; }
}

public class ListApiResponse<T>
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public List<T>? Data { get; set; }
}
