window.languageManager = {
    saveLanguage: function (lang) {
        localStorage.setItem("language", lang);
    },

    getLanguage: function () {
        return localStorage.getItem("language") || "en"; // اللغة الافتراضية
    }
};
