using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using JetBrains.Annotations;
using Microsoft.Build.Utilities;
using Nuke.Common.Tooling;

namespace Nuke.Common.Tools.MicrosoftTeams
{
    [PublicAPI]
    public static class MicrosoftTeamsTasks
    {
        public static void SendMicrosoftTeamsMessage(Configure<MicrosoftTeamsMessageCard> configurator, string webhook)
        {
            SendMicrosoftTeamsMessageAsync(configurator, webhook).Wait();
        }

        public static async Task SendMicrosoftTeamsMessageAsync(Configure<MicrosoftTeamsMessageCard> configurator, string webhook)
        {
            var message = configurator(new MicrosoftTeamsMessageCard());

            using (var client = new WebClient())
            {
                var response = await client.UploadDataTaskAsync(webhook, "POST", null);
                var responseText = Encoding.UTF8.GetString(response);
                ControlFlow.Assert(responseText == "ok", $"'{responseText}' == 'ok'");
            }
        }
    }
}
