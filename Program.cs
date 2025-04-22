// See https://aka.ms/new-console-template for more information
using System.Text.Json.Nodes;

Console.WriteLine("Hello, World!");

JsonObject secrets = BeyondInsight.BeyondInsight.getSecrets();

Console.WriteLine(GetNodeByPath(secrets, "abdulmelik/Dev/hola2"));




static JsonNode? GetNodeByPath(JsonObject root, string path)
{
    if (root == null || string.IsNullOrWhiteSpace(path))
        return null;

    string[] keys = path.Split('/', StringSplitOptions.RemoveEmptyEntries);

    JsonNode? current = root;
    foreach (var key in keys)
    {
        if (current is JsonObject obj && obj.ContainsKey(key))
        {
            current = obj[key];
        }
        else
        {
            return null; // Yol eksik veya hatalıysa null dönüyoruz
        }
    }

    return current;
}