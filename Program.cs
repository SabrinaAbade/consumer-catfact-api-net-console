using System.Text.Json;

Console.WriteLine("Fato sobre Gatos:");

using HttpClient client = new HttpClient();

string resposta = await client.GetStringAsync("https://catfact.ninja/fact");

using JsonDocument json = JsonDocument.Parse(resposta);

string fato = json.RootElement.GetProperty("fact").GetString()!;

Console.WriteLine(fato);
