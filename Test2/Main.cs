using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2.Handlers;
using Exiled.API.Features.Roles;
using CommandSystem.Commands.Console;


using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;
using Warhead = Exiled.Events.Handlers.Warhead;
using Map = Exiled.Events.Handlers.Map;
using Exiled.Events.Handlers;

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
            Server.WaitingForPlayers += server.OnWaitingForPlayers;
            Server.RoundStarted += server.OnRoundStarted;
            Server.RespawningTeam += server.OnRespawningTeam;  
          
            Player.Joined += player.OnJoined;
            Player.Left += player.OnLeft;

           
            Player.Died += player.OnDeath;
            Warhead.Starting += warhead.OnStarting;
            Warhead.Stopping += warhead.OnStopping;
            Warhead.Detonated += warhead.OnDetonated;

            


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
            warhead = null;
            server = null;
            player = null;
        }
   
        
    }
}
