using System;
using CommandSystem;
using Exiled.API.Features;
using GameCore;
using RemoteAdmin;

namespace Test2
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    internal class scp1956 : ICommand
    {
    
        public string Command { get; } = "scp1956";
       
        public string[] Aliases { get; } = new[]{ "1956" };

        public string Description { get; } = "A command that do something magic";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if(RoundStart.RoundStarted == true)
            {
                // Извлекаем PlayerID из аргументов команды
                if (arguments.Count < 1 || !int.TryParse(arguments.At(0), out int playerID))
                {
                    response = "Invalid arguments. Usage: \"1956 [PlayerID]\"";
                    return false;
                }

                // Получаем игрока по ID
                Player player = Player.Get(playerID);
                if (player == null)
                {
                    response = $"Player with ID {playerID} not found.";
                    return false;
                }

                // Устанавливаем игроку класс D
                player.Role.Set(PlayerRoles.RoleTypeId.ClassD);
                player.Health = 500;
                player.Heal(500);
                player.Scale = new UnityEngine.Vector3(1.3f, 0.7f, 1);
                response = $"Player {player.Nickname} has been assigned Class D role.";
                return true;
            }
            response = "Round is not started";
            return false;
        
        }
     
    }                                                                           

}
