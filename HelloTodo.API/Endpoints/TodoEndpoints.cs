using HelloTodo.API.Entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace HelloTodo.API.Endpoints
{
    public static class TodoEndpoints
    {
        public static WebApplication AddTodoEndpoints(this WebApplication app)
        {
            Todo[] sampleTodos =
            [
                new(1, "Walk the dog"),
                new(2, "Do the dishes", DateOnly.FromDateTime(DateTime.Now)),
                new(3, "Do the laundry", DateOnly.FromDateTime(DateTime.Now.AddDays(1))),
                new(4, "Clean the bathroom"),
                new(5, "Clean the car", DateOnly.FromDateTime(DateTime.Now.AddDays(2)))
            ];
            app.MapGet("/", () => sampleTodos)
                    .WithName("GetTodos");


            app.MapGet("/{id}", Results<Ok<Todo>, NotFound> (int id) =>
                sampleTodos.FirstOrDefault(a => a.Id == id) is { } todo
                    ? TypedResults.Ok(todo)
                    : TypedResults.NotFound())
                .WithName("GetTodoById");
            return app;
        }
    }
}
