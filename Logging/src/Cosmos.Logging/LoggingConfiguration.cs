﻿using System;
using System.Collections.Generic;
using Cosmos.Logging.Configurations;
using Cosmos.Logging.Events;
using Cosmos.Logging.Filters;
using Microsoft.Extensions.Configuration;

namespace Cosmos.Logging {
    public partial class LoggingConfiguration {
        private readonly IConfigurationRoot _loggingConfiguration;
        private readonly NamespaceNavigatorCache _namespaceNavigatorCache;
        private readonly List<NamespaceNavigator> _namespaceFilterNavRoots = new List<NamespaceNavigator>();

        public LoggingConfiguration() { }

        public LoggingConfiguration(IConfigurationRoot loggingConfiguration) {
            _loggingConfiguration = loggingConfiguration ?? throw new ArgumentNullException(nameof(loggingConfiguration));
            _namespaceNavigatorCache = new NamespaceNavigatorCache(new NamespaceNavigationParser());
            SetSelf(loggingConfiguration.GetSection("Logging").Get<LoggingConfiguration>());
        }

        public bool IncludeScopes { get; set; }

        public Dictionary<string, string> LogLevel { get; set; } = new Dictionary<string, string>();

        public Dictionary<string, string> Aliases { get; set; } = new Dictionary<string, string>();

        public IReadOnlyList<NamespaceNavigator> NamespaceFilterNavs => _namespaceFilterNavRoots;

        public LogEventLevel GetDefaultMinimumLevel() => NavigationFilterProcessor.GetDefault();

        public DestructureConfiguration Destructure { get; set; }

        public IConfigurationRoot Configuration => _loggingConfiguration;
    }
}