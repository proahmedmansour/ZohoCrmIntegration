using Com.Zoho.Crm.API.Dc;
namespace Adva.ZohoCrm.Configurations
{
    public class CustomDataCenter : DataCenter
    {
        private static readonly CustomDataCenter US = new CustomDataCenter();

        private CustomDataCenter()
        {
        }

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Production Environment in US Domain.
        /// </summary>
        public static readonly Environment PRODUCTION = new Environment("us_prd", "https://www.zohoapis.com", US.GetIAMUrl(), US.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Sandbox Environment in US Domain.
        /// </summary>
        public static readonly Environment SANDBOX = new Environment("us_sdb", "https://sandbox.zohoapis.com", US.GetIAMUrl(), US.GetFileUploadUrl());

        /// <summary>
        /// This Environment class instance represents the Zoho CRM Developer Environment in US Domain.
        /// </summary>
        public static readonly Environment DEVELOPER = new Environment("us_dev", "https://developer.zohoapis.com", US.GetIAMUrl(), US.GetFileUploadUrl());

        public override string GetIAMUrl()
        {
            return "https://accounts.zoho.com/oauth/v2/token";
        }

        public override string GetFileUploadUrl()
        {
            return "https://content.zohoapis.com";
        }
    }
}

