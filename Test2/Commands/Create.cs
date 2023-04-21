using CommandSystem;
using Exiled.API.Features;
using Exiled.API.Features.Pickups;
using Exiled.API.Interfaces;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Extensions;
using Mirror;
using PluginAPI.Core.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Test2.Config;
namespace Test2.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    internal class Create : ICommand
    {
        public string Command { get; } = "create";

        public string[] Aliases { get; } = new[] { "cr" };

        public string Description { get; } = "create";
        private List<Player> listplayers = scp1956.players1956List;

        private int points;
        
        string substringToRemove = "Points";
        string newString;
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            points = Appart.points;
            Appart.points = 10;
           
            Player player = Player.Get(sender);
            if(listplayers.Contains(player) == true)
            {
                Log.Info(points);
                if (points != 0)
                {
                    foreach (var item in Enum.GetValues(typeof(PointsForItems)))
                    {
                        if(points <= (int)item)
                        {
                            newString = item.ToString().Replace(substringToRemove, "");
                        }
                    }

                    foreach (ItemType item1 in Enum.GetValues(typeof(ItemType)))
                    {
                        if (item1.ToString() == newString)
                        {
                            points -= (int)item1;
                            Appart.points = points;

                            Vector3 spawnPosition = player.Position + new Vector3(0f, 2f, 0f);
                            ItemType itemType = item1;
                            Pickup pickup = Pickup.Spawn(Pickup.Create(itemType), spawnPosition, Quaternion.identity);
                            NetworkServer.Spawn(pickup.GameObject);
                            Log.Info(points);
                            response = "Предмет успешно создан ";
                            return true;
                        }

                    }
                }
                response = "Недостаточно очков ";
                return false;
            }
            else
            {
                response = "Пошел нахуй фемка! ";
                return false;
            }
        }
    }
}
