window.themeManager = {
    saveTheme: function (theme) {
        localStorage.setItem("theme", theme);
    },

    getTheme: function () {
        // لو ماكو شيء مخزون يرجع "light"
        return localStorage.getItem("theme") || "light";
    },

    applyDark: function () {
        document.documentElement.classList.add("dark");
    },

    applyLight: function () {
        document.documentElement.classList.remove("dark");
    }
};

// يشتغل قبل Blazor: يطبق الثيم المحفوظ
(function () {
    const saved = localStorage.getItem("theme") || "light";

    if (saved === "dark") {
        document.documentElement.classList.add("dark");
    } else {
        document.documentElement.classList.remove("dark");
    }
})();
