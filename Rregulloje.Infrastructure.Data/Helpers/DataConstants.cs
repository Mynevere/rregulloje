using System;
using System.Collections.Generic;
using System.Text;

namespace Rregulloje.Infrastructure.Data.Helpers
{
    public static class DataConstants
    {
        public class AppSettings
        {
            public const string ConnectionString = "RregullojeDB";
        }

        public class EmailTemplates
        {
            public const string SendEmail = "SendEmail";

            public const string SendUserMessageEmail = "SendUserMessageEmail";
        }

        public class Settings
        {
            public const string ClientBaseUrl = "ClientBaseUrl";

            public const string ApiBaseUrl = "ApiBaseUrl";
        }
    }
}
