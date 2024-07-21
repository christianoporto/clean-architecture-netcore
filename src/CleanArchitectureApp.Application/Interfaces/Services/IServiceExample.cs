namespace CleanArchitectureApp.Application.Interfaces.Services
{
    public interface IServiceExample
    {
        Task<IEnumerable<string>> RunAsync();
    }
}
