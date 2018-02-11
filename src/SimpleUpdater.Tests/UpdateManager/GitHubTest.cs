﻿using System;
using System.Collections.Generic;
using System.Text;

using Xunit;

using SimpleUpdater.UpdateManager;

namespace SimpleUpdater.Tests
{
    public class GitHubTest
    {
        GitHub mgr;

        public GitHubTest()
        {
            mgr = new GitHub("https://github.com/kuttsun/Test");
        }

        [Fact]
        public void CheckForUpdateTest()
        {
            var appInfo = mgr.CheckForUpdateAsync().Result;
            Assert.NotNull(appInfo);
        }

        [Fact]
        public void PreparingForUpdateTest()
        {
            Assert.True(mgr.PreparingForUpdate("test.zip").Result);
        }
    }
}
