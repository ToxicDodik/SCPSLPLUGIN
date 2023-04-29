using Exiled.API.Features;
using System;
using Exiled.API.Enums;

using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;
using Warhead = Exiled.Events.Handlers.Warhead;
using Map = Exiled.Events.Handlers.Map;


namespace Test2
{
    public class Main : Plugin<Config>
    {
        private static readonly Lazy<Main> LazyInstance = new Lazy<Main>(valueFactory: () => new Main());
        public Main Instance => LazyInstance.Value;
        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        private Handlers.Server server;
        private Handlers.Player player;
        private Handlers.Warhead warhead;
        private Handlers.Map map;
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
            warhead = new Handlers.Warhead();
            map = new Handlers.Map();

            Server.WaitingForPlayers += server.OnWaitingForPlayers;
            Server.RoundStarted += server.OnRoundStarted;
            Server.RespawningTeam += server.OnRespawningTeam;

            Player.Joined += player.OnJoined;
            Player.Left += player.OnLeft;
            Player.Died += player.OnDeath;

            Warhead.Starting += warhead.OnStarting;
            Warhead.Stopping += warhead.OnStopping;
            Warhead.Detonated += warhead.OnDetonated;
            Warhead.ChangingLeverStatus += warhead.OnChangingLeverStatus;
            Map.Decontaminating += map.OnDecontaminating;
            Map.GeneratorActivated += map.OnGeneratorActivated;

        }

        public void UnRegisterEvents()
        {
            Server.WaitingForPlayers -= server.OnWaitingForPlayers;
            Server.RoundStarted -= server.OnRoundStarted;
            Server.RespawningTeam -= server.OnRespawningTeam;

            Player.Died -= player.OnDeath;
            Player.Joined -= player.OnJoined;
            Player.Left -= player.OnLeft;

            Warhead.Starting -= warhead.OnStarting;
            Warhead.Stopping -= warhead.OnStopping;
            Warhead.Detonated -= warhead.OnDetonated;
            Warhead.ChangingLeverStatus -= warhead.OnChangingLeverStatus;
            
            Map.Decontaminating -= map.OnDecontaminating;
            Map.GeneratorActivated -= map.OnGeneratorActivated;
            warhead = null;
            server = null;
            player = null;
            map = null;

        }


  
    }
}