using System;
using CommandSystem;
using Exiled.API.Features;
using GameCore;
using RemoteAdmin;
using System.Collections.Generic;
using Exiled.API.Extensions;

namespace Test2
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    internal class scp1956 : ICommand  
    {
    
        public string Command { get; } = "scp1956";
        
        public string[] Aliases { get; } = new[]{ "1956" };

        public string Description { get; } = "A command that do something magic";

        public List<Player> players1956List = new List<Player>();
        public int Points;
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!Round.IsStarted)
            {
                response = "Round is not started";
                return false;
            }
            // Извлекаем PlayerID из аргументов команды
            if (arguments.Count < 1 || !int.TryParse(arguments.At(0), out int playerID))
            {
                response = "Invalid arguments. Usage: \"1956 [PlayerID]\"";
                return false;
            }

            // Получаем игрока по ID
            Player player = Player.Get(sender);
            
            if (player == null)
            {
                response = $"Player with ID {playerID} not found.";
                return false;
            }

            if(players1956List.Contains(player) == true)
            {
                response = $"Игрок с указанным ID, уже является SCP-1956";
                return false;
            }
            else
            {
                
                players1956List.Add(player);
                Exiled.API.Features.Log.Info(players1956List[0]);
                player.Role.Set(PlayerRoles.RoleTypeId.ClassD);
                player.Health = 500;
                player.Scale = new UnityEngine.Vector3(1.3f, 0.7f, 1);
                response = $"Player {player.Nickname} has been assigned Class D role.";
                return true;
            }




        }

     
    }                                                                           

}
