namespace CopilotTrainingApp.Services
{
    public class ApiDataService
    {
        public Task<List<string>> GetDataAsync()
        {
            return Task.FromResult(new List<string> { "Sample A", "Sample B", "Sample C" });
        }
    }
}