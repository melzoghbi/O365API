using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICore1
{
    /// <summary>
    /// A class that represent the app custom configuration
    /// We Added custom settings section in appsettings.json file
    /// as one the standard sources for .net core app.
    /// Check startup.cs for loading the custom section into the configuration
    /// </summary>
    public class Config
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

        public string MessageSubject { get; set; }

        public string MessageBody { get; set; }
    }
}
