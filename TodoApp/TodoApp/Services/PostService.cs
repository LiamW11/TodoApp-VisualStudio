using System.Net.Http.Json;
using YourApp.Models;

namespace YourApp.Services;

public sealed class PostService
{
    private readonly HttpClient _http;

    public PostService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Post>> GetPostsAsync()
    {
        // JSONPlaceholder är ett exempel-API
        var result = await _http.GetFromJsonAsync<List<Post>>(
            "https://jsonplaceholder.typicode.com/posts"
        );

        // Gör null säkert: returnera tom lista om något oväntat händer
        return result ?? new List<Post>();
    }
}