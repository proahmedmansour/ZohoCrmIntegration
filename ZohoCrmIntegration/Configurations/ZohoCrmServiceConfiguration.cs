using Adva.ZohoCrm.Configurations;
using Com.Zoho.API.Authenticator;
using Com.Zoho.API.Authenticator.Store;
using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Logger;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using SDKInitializer = Com.Zoho.Crm.API.Initializer;

namespace ZohoCrmIntegration.Configurations
{
    public static class ServicesConfiguration
    {
        public static void AddZohoCrmSDKServiceConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration.GetSection("ZohoSettings").Get<ZohoConfigurationSettings>();

            Logger logger = new Logger.Builder()
                .Level(Logger.Levels.ALL)
                .FilePath(settings.LogFilePath)
                .Build();

            UserSignature user = new(settings.CurrentUserEmail);

            Environment environment = CustomDataCenter.PRODUCTION;

            Token token = new OAuthToken.Builder()
                .ClientId(settings.ClientId)
                .ClientSecret(settings.ClientSecret)
                .RefreshToken(settings.Refreshtoken)
                .RedirectURL(settings.RedirectUri)
                .Build();

            TokenStore tokenstore = new FileStore(settings.OauthTokensFilePath);

            SDKConfig config = new SDKConfig.Builder()
            .AutoRefreshFields(true)
            .PickListValidation(false)
            .Build();

            string resourcePath = settings.ResourcesPath;

            new SDKInitializer.Builder()
                .User(user)
                .Environment(environment)
                .Token(token)
                .Store(tokenstore)
                .SDKConfig(config)
                .ResourcePath(resourcePath)
                .Logger(logger)
                .Initialize();
        }
    }
}

