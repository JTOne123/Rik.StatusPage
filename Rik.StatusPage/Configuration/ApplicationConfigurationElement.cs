﻿using System.Configuration;

namespace Rik.StatusPage.Configuration
{
    public class ApplicationConfigurationElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name => (string) this["name"];
    }
}