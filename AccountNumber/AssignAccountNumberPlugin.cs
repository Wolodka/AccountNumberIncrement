using AccountNumber.Res;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountNumber
{
    class AssignAccountNumberPlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            Entity createdAccount = null;

            var pluginExecutionContext =
             (IPluginExecutionContext)serviceProvider.GetService(
             typeof(IPluginExecutionContext));

            if (pluginExecutionContext.PrimaryEntityName != Strings.ACCOUNT_ENTITY_NAME &&
                    pluginExecutionContext.MessageName != Strings.PLUGIN_EVENT_CREATE)
            {
                throw new Exception(ExceptionMessages.WRONG_ENTITY_OR_EVENT);
            }

            if (pluginExecutionContext.InputParameters.Contains(Strings.PLUGIN_TARGET_PARAM_NAME) &&
             pluginExecutionContext.InputParameters[Strings.PLUGIN_TARGET_PARAM_NAME] is Entity)
            {
                createdAccount = (Entity)pluginExecutionContext.InputParameters[Strings.PLUGIN_TARGET_PARAM_NAME];
            }
            else
            {
                throw new Exception(ExceptionMessages.NO_TARGET_ENTITY);
            }

            try
            {
                var factory = (IOrganizationServiceFactory)serviceProvider
                    .GetService(typeof(IOrganizationServiceFactory));

                var service = factory.CreateOrganizationService(pluginExecutionContext.UserId);

                CrmService.Init(service);

                NewNumberAssigner.Assign(createdAccount.Id);

            }
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(
                   ExceptionMessages.EXCEPTION_OCCURED_IN_PLUGIN, ex);
            }
        }
    }
}
