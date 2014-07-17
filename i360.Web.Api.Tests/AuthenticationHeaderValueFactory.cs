﻿using System;
using System.Net.Http.Headers;
using System.Text;
using i360.Web.Api.Tests.Properties;

namespace i360.Web.Api.Tests
{
    internal class AuthenticationHeaderValueFactory
    {
        public static AuthenticationHeaderValue Create()
        {
            var userId = Settings.Default.UserId;
            return Create(userId);
        }

        public static AuthenticationHeaderValue Create(Guid userProviderKey)
        {
            string authInfo = userProviderKey + ":" + string.Empty;
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            var authenticationHeaderValue = new AuthenticationHeaderValue("Basic", authInfo);
            return authenticationHeaderValue;
        }
    }
}
