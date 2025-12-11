using Microsoft.JSInterop;

namespace AdminPannelLast.Services.Auth;

public interface ITokenStorage
{
    Task SetTokenAsync(string token);
    Task<string?> GetTokenAsync();
    Task ClearAsync();
}

public class LocalStorageTokenStorage : ITokenStorage
{
    private readonly IJSRuntime _jsRuntime;
    private const string Key = "auth_token";

    public LocalStorageTokenStorage(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task SetTokenAsync(string token)
    {
        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", Key, token);
    }

    public async Task<string?> GetTokenAsync()
    {
        return await _jsRuntime.InvokeAsync<string?>("localStorage.getItem", Key);
    }

    public async Task ClearAsync()
    {
        await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", Key);
    }
}
