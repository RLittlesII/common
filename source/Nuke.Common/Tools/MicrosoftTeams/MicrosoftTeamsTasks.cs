using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Newtonsoft.Json;
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
            var payload = JsonConvert.SerializeObject(message);
            var data = new NameValueCollection { ["payload"] = payload };

            using (var client = new WebClient())
            {
                var response = await client.UploadDataTaskAsync(webhook, "POST", null);
                var responseText = Encoding.UTF8.GetString(response);
                ControlFlow.Assert(responseText == "ok", $"'{responseText}' == 'ok'");
            }
        }
    }
}
