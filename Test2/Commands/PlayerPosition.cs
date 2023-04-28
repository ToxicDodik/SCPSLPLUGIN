using CommandSystem;
using Exiled.API.Features;
using Exiled.Events.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    internal class PlayerPosition : ICommand
    {

        public string Command { get; } = "playerposition";

        public string[] Aliases { get; } = new[] { "pos" };

        public string Description { get; } = "A command which return position of player";



        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            var player = Exiled.API.Features.Player.Get(sender);
            response = player.Position.ToString();
            return true;
        }
    }
}