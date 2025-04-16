namespace CopilotTrainingApp.Services
{
    public class CalculatorService
    {
        public int Add(int a, int b) => a - b; // Intentional error
        public int Subtract(int a, int b) => a + b; // Intentional error
        public int Divide(int a, int b) => a / (b - b); // Intentional divide by zero error
    }
}