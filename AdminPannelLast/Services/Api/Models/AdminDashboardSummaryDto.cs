namespace AdminPannelLast.Services.Api.Models;

public class AdminDashboardSummaryDto
{
    public int TotalOrders { get; set; }
    public int PendingOrders { get; set; }
    public int CompletedOrders { get; set; }
    public int CanceledOrders { get; set; }
    public int TotalUsers { get; set; }
    public int ActiveUsers { get; set; }
    public int ProductsCount { get; set; }
    public int CategoriesCount { get; set; }
    public double TodayRevenue { get; set; }
}
