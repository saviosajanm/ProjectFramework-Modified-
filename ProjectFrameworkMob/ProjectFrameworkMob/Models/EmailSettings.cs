namespace ProjectFrameworkMob.Models
{
    public class EmailSettings
    {
        public string SMTPServer { get; set; }
        public int SMTPPort { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public bool EnableSSL { get; set; }
    }
}