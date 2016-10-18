using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;

namespace WebAPICore1.Helpers
{
    // Store session object keys, 
    // in this case, access token and info about the current logged in user.
    public static class SessionKeys
    {
        public static class Login
        {
            public static string AccessToken = nameof(AccessToken);
            public static UserProfile UserInfo = new UserProfile();
        }
    }
}
