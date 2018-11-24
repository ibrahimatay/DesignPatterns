using System;

namespace DesignPatterns.Singleton
{
    public class ConfigurationManagement
    {
        private static ConfigurationManagement _configurationManagement;
        public Guid Id { get; set; }

        private ConfigurationManagement(Guid id)
        {
            this.Id = id;
        }

        public static ConfigurationManagement GetConfigurationManagementInstance()
        {
            if(_configurationManagement ==null)
                _configurationManagement = new ConfigurationManagement(Guid.NewGuid());

            return _configurationManagement;
        }
    }
}