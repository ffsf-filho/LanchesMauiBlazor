using LanchesLibrary.Data;

namespace LanchesWeb.Data;

public class LanchesService : ILancheService
{
    private readonly HttpClient _httpClient = new();

    public async Task<List<Lanche>>? LoadLanchesAsync()
    {
        string url = "https://www.macoratti.net/Sistemas/lanches.json";

        List<Lanche>? lanches = await _httpClient.GetFromJsonAsync<List<Lanche>>(url);

        return lanches!;
    }
}
