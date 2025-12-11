public class LanguageService
{
    // اللغة الحالية: ar أو en
    public string Language { get; private set; } = "ar";

    // اتجاه الصفحة
    public string Direction => Language == "ar" ? "rtl" : "ltr";

    // حدث تبليغ عند تغيير اللغة
    public event Action? OnChange;

    // تغيير اللغة
    public void SetLanguage(string lang)
    {
        Language = (lang == "ar") ? "ar" : "en";
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
