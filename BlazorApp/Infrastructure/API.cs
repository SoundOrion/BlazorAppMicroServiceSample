namespace BlazorApp.Infrastructure;

public static class API
{

    public static class Sample
    {
        public static string GetSample(string baseUri) => $"{baseUri}";
    }
}
