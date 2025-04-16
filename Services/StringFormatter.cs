namespace CopilotTrainingApp.Services
{
    public class StringFormatter
    {
        public string FormatMessage(string name, int age)
        {
            if (name == null)
                return "Name missing";
            if (age < 0)
                return "Invalid age";
            if (name.Length > 0 && age >= 0)
            {
                return name.ToUpper() + " is " + age + " years old.";
            }
            else
            {
                return "Error";
            }
        }
    }
}