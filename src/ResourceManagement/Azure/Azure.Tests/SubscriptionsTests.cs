﻿using Microsoft.Azure.Management.V2.Resource;
using Microsoft.Azure.Management.V2.Resource.Authentication;
using Microsoft.Azure.Management.V2.Resource.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static Microsoft.Azure.Management.V2.Resource.ResourceManager2;

namespace Azure.Tests
{
    public class SubscriptionsTests
    {
        [Fact(Skip = "TODO: Convert to recorded tests")]
        public void CanListSubscriptions()
        {
            var resourceManager = CreateResourceManager();
            var subscriptions = resourceManager.Subscriptions.List();
            Assert.True(subscriptions.Count > 0);
        }

        [Fact(Skip = "TODO: Convert to recorded tests")]
        public void CanListLocations()
        {
            var resourceManager = CreateResourceManager();
            var subscription = resourceManager.Subscriptions.List().First();
            var locations = subscription.ListLocations();
            Assert.True(locations.Count > 0);
        }

        private IAuthenticated CreateResourceManager()
        {
            ApplicationTokenCredentials credentials = new ApplicationTokenCredentials(@"C:\my.azureauth");
            IAuthenticated resourceManager = ResourceManager2.Configure()
                .withLogLevel(HttpLoggingDelegatingHandler.Level.BODY)
                .Authenticate(credentials);
            return resourceManager;
        }
    }
}
