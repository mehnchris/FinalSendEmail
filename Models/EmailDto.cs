namespace FinalSendEmail.Models
{
    public class EmailDto
    {
        public string recipient { get; set; } = string.Empty;
        public string subject { get; set; } = string.Empty;
        public string body { get; set; } = string.Empty;
    }
}
