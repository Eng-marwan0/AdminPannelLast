window._charts = window._charts || {};

window.renderDashboardChart = (canvasId, labels, data) => {
    const el = document.getElementById(canvasId);
    if (!el) return;
    const ctx = el.getContext && el.getContext("2d");
    if (!ctx) return;

    // Destroy existing chart instance if present
    if (window._charts[canvasId]) {
        try { window._charts[canvasId].destroy(); } catch (e) { }
        window._charts[canvasId] = null;
    }

    window._charts[canvasId] = new Chart(ctx, {
        type: "line",
        data: {
            labels: labels,
            datasets: [{
                label: "عدد الطلبات",
                data: data,
                borderWidth: 2,
                borderColor: "rgba(75, 192, 192, 1)",
                backgroundColor: "rgba(75, 192, 192, 0.2)",
                tension: 0.4,
                pointRadius: 3
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            plugins: {
                legend: { display: false }
            },
            scales: {
                x: { grid: { display: false } },
                y: { beginAtZero: true }
            }
        }
    });
};

window.renderStatusPieChart = (canvasId, labels, data) => {
    const el = document.getElementById(canvasId);
    if (!el) return;
    const ctx = el.getContext && el.getContext("2d");
    if (!ctx) return;

    if (window._charts[canvasId]) {
        try { window._charts[canvasId].destroy(); } catch (e) { }
        window._charts[canvasId] = null;
    }

    window._charts[canvasId] = new Chart(ctx, {
        type: "pie",
        data: {
            labels: labels,
            datasets: [{
                data: data,
                backgroundColor: [
                    "rgba(75, 192, 192, 0.8)",
                    "rgba(255, 206, 86, 0.8)",
                    "rgba(255, 99, 132, 0.8)",
                    "rgba(54, 162, 235, 0.8)"
                ],
                borderColor: [
                    "rgba(255,255,255,0.05)",
                    "rgba(255,255,255,0.05)",
                    "rgba(255,255,255,0.05)",
                    "rgba(255,255,255,0.05)"
                ],
                borderWidth: 1
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            plugins: {
                legend: { position: 'bottom' }
            }
        }
    });
};
