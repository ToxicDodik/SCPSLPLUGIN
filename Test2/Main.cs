using Exiled.API.Features;
using System;
using Exiled.API.Enums;

using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;



namespace Test2
{
    public class Main : Plugin<Config>
    {
        private static readonly Lazy<Main> LazyInstance = new Lazy<Main>(valueFactory: () => new Main());
        public Main Instance => LazyInstance.Value;
        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        private Handlers.Server server;
        private Handlers.Player player;
       
      
        public override void OnEnabled()
        {
            RegisterEvents();

        }

        public override void OnDisabled()
        {
            UnRegisterEvents();
        }

        public void RegisterEvents()
        {
            server = new Handlers.Server();
            player = new Handlers.Player();
          

            Server.WaitingForPlayers += server.OnWaitingForPlayers;
            Server.RoundStarted += server.OnRoundStarted;
            Server.RespawningTeam += server.OnRespawningTeam;

        }

        public void UnRegisterEvents()
        {
            Server.WaitingForPlayers -= server.OnWaitingForPlayers;
            Server.RoundStarted -= server.OnRoundStarted;
            Server.RespawningTeam -= server.OnRespawningTeam;
            server = null;
            player = null;
           

        }


  
    }
}