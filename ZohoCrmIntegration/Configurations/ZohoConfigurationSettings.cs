namespace ZohoCrmIntegration.Configurations
{
    public class ZohoConfigurationSettings
    {
        public string ClientId { get; set; }

        public string RedirectUri { get; set; }

        public string ClientSecret { get; set; }

        public string AccessType { get; set; }

        public string MySqlUsername { get; set; }

        public string MySqlPassword { get; set; }

        public string MySqlDatabase { get; set; }

        public string MySqlServer { get; set; }

        public string MySqlPort { get; set; }

        public string OauthTokensFilePath { get; set; }

        public string LogFilePath { get; set; }

        public string Timeout { get; set; }

        public string MinLogLevel { get; set; }

        public string DomainSuffix { get; set; }

        public string CurrentUserEmail { get; set; }

        public string Refreshtoken { get; set; }

        public string ResourcesPath { get; set; }
    }
}