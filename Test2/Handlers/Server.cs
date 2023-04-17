using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Handlers
{
    internal class Server
    {
        public void OnWaitingForPlayers()
        {
            Log.Info("Waiting for players");
        }
        public void OnRoundStarted() {
            Log.Info("Round Started");
        }
        public void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            Log.Info($"{ev.NextKnownTeam} have been respawned");
        }
    }
}
