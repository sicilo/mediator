namespace SoftwareArchitecture.DesignPatterns.Mediator.Models
{
    public record MessageModel
    {
        public string Message { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
