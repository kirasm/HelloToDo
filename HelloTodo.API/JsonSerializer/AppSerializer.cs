using HelloTodo.API.Entities;
using System.Text.Json.Serialization;

namespace HelloTodo.API.JsonSerializer
{
    [JsonSerializable(typeof(Todo[]))]
    internal partial class AppJsonSerializerContext : JsonSerializerContext
    {

    }
}
