using System;
using System.Collections.Generic;
using CommandSystem;
using Exiled.API.Features;
using static Test2.Config;

namespace Test2.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    internal class Appart : ICommand
    {
        public static int points;
        private List<Player> playerlist = scp1956.players1956List;
        public string Command { get; } = "appart";

        public string[] Aliases { get; } = new[] { "ap" };

        public string Description { get;  } = "deleted";
        
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
           
            Player player = Player.Get(sender);
            if(playerlist.Contains(player) == true)
            {
                
                if(player.CurrentItem != null)
                {

                    var item = player.CurrentItem.Type;
                    player.CurrentItem.Destroy();
                    switch (item)
                    {
                        
                        //Карты допуска 
                        case ItemType.KeycardJanitor:
                            points += (int)PointsForItems.PointsKeycardJanitor;
                            player.Broadcast(5, "Предмет успешно удален, вы получили очки создания.");
                            response = "Предмет успешно удален";
                            return true; 
                        case ItemType.KeycardScientist:
                            points += (int)PointsForItems.PointsKeycardScientist;
                            response = "Предмет успешно удален";
                            player.Broadcast(5, "Предмет успешно удален, вы получили очки создания.");
                            return true;
                        case ItemType.KeycardZoneManager:
                            points += (int)PointsForItems.PointsKeycardZoneManager;
                            response = "Предмет успешно удален";
                            player.Broadcast(5, "У тебя нет прав, ты фемка");
                            return true;
                        case ItemType.KeycardGuard:
                            points += (int)PointsForItems.PointsKeycardGuard;
                            response = "Предмет успешно удален";
                            player.Broadcast(5, "Предмет успешно удален, вы получили очки создания.");
                            return true;
                        case ItemType.KeycardNTFOfficer:
                            points += (int)PointsForItems.PointsKeycardLieutenant;
                            response = "Предмет успешно удален";
                            player.Broadcast(5, "Предмет успешно удален, вы получили очки создания.");
                            return true;
                        case ItemType.KeycardNTFLieutenant:
                            points += (int)PointsForItems.PointsKeycardLieutenant;
                            response = "Предмет успешно удален";
                            player.Broadcast(5, "Предмет успешно удален, вы получили очки создания.");
                            return true;
                        case ItemType.KeycardNTFCommander:
                            points += (int)PointsForItems.PointsKeycardCapitan;
                            response = "Предмет успешно удален";
                            player.Broadcast(5, "Предмет успешно удален, вы получили очки создания.");
                            return true;
                        case ItemType.KeycardChaosInsurgency :
                            points += (int)PointsForItems.PointsKeycardChaosInsurgency;
                            response = "Предмет успешно удален";
                            player.Broadcast(5, "Предмет успешно удален, вы получили очки создания.");
                            return true;
                        case ItemType.KeycardFacilityManager:
                            points += (int)PointsForItems.PointsKeycardManager;
                            response = "Предмет успешно удален";
                            player.Broadcast(5, "Предмет успешно удален, вы получили очки создания.");
                            return true;
                        case ItemType.KeycardO5:
                            points += (int)PointsForItems.PointsKeycardO5;
                            Log.Info(points);
                            response = "Предмет успешно удален";
                            player.Broadcast(5, "Предмет успешно удален, вы получили очки создания.");
                            return true;

                        //Оружие 
                        case ItemType.GunCOM15:
                            points += ((int)PointsForItems.PointsCOM15);
                            response = "Предмет успешно удален";
                            player.Broadcast(5, "Предмет успешно удален, вы получили очки создания.");
                            return true;
                        case ItemType.GunCOM18:
                            points += (int)PointsForItems.PointsCOM18;
                            response = "Предмет успешно удален";
                            player.Broadcast(5, "Предмет успешно удален, вы получили очки создания.");
                            return true;
                        case ItemType.GunFSP9:
                            points += (int)PointsForItems.PointsFSP9;
                            response = "Предмет успешно удален";
                            player.Broadcast(5, "Предмет успешно удален, вы получили очки создания.");
                            return true;
                        case ItemType.GunCrossvec:
                            points += (int)PointsForItems.PointsCrossvec;
                            response = "Предмет успешно удален";
                            player.Broadcast(5, "Предмет успешно удален, вы получили очки создания.");
                            return true;
                        case ItemType.GunE11SR:
                            points += (int)PointsForItems.PointsE11_SR;
                            response = "Предмет успешно удален";
                            player.Broadcast(5, "Предмет успешно удален, вы получили очки создания.");
                            return true;
                        case ItemType.GunLogicer:
                            points += (int)PointsForItems.PointsLogicer;
                            response = "Предмет успешно удален";
                            player.Broadcast(5, "Предмет успешно удален, вы получили очки создания.");
                            return true;
                        case ItemType.MicroHID:
                            points += (int)PointsForItems.PointsMicroHID;
                            response = "Предмет успешно удален";
                            player.Broadcast(5, "Предмет успешно удален, вы получили очки создания.");
                            return true;
                        default:
                            response = "Error";
                            return false;
                            
                    }

                }
                player.Broadcast(5, "Пидор у тебя нет предмета в руках");
                response = " Пидор у тебя нет предмета в руках";
                return true;
            }
            else 
            {
                player.Broadcast(5, "У тебя нет прав, ты фемка");
                response = " У вас нету доступа к данной комманде";
                return false;
            }
        }
    }
}
