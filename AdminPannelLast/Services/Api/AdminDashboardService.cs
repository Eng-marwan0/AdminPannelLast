using System.Net.Http.Json;
using AdminPannelLast.Services.Api.Models;

namespace AdminPannelLast.Services.Api;

public class AdminDashboardService
{
    private readonly HttpClient _httpClient;

    public AdminDashboardService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // ?????? ???? ???? ?????? ?? API ??????
    public async Task<ApiResponse<AdminDashboardSummaryDto>?> GetSummaryAsync()
    {
        // ?????? ?????? ?? API: /api/admin/dashboard/summary
        return await _httpClient.GetFromJsonAsync<ApiResponse<AdminDashboardSummaryDto>>("api/admin/dashboard/summary");
    }
}
