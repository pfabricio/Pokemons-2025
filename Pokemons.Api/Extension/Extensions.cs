namespace Pokemons.Api.Extension;

public static class Extensions
{
    public static string GetQueryString(this string url)
    {
        var queryString = string.Empty;
        if (string.IsNullOrEmpty(url)) return queryString;
        var uri = new Uri(url);
        queryString = uri.Query;
        return queryString;
    }
}