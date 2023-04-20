using System;
using CommandSystem;
using Exiled.API.Features;
using static Test2.Config;

namespace Test2.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    internal class Appart : ICommand
    {
        private scp1956 scp = new scp1956();
        public string Command { get; } = "appart";

        public string[] Aliases { get; } = new[] { "ap" };

        public string Description { get;  } = "deleted";
        
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = Player.Get(sender);
            if(scp.players1956List.Contains(player) == true)
            {
                
                if(player.CurrentItem != null)
                {

                    var item = player.CurrentItem.Type;
                    player.CurrentItem.Destroy();
                    switch (item)
                    {
                        //Карты допуска 
                        case ItemType.KeycardJanitor:
                            scp.Points = ((int)PointsForItems.PointsKeycardJanitor);
                            response = "Предмет успешно удален";
                            return true; 
                        case ItemType.KeycardScientist:
                            scp.Points = ((int)PointsForItems.PointsKeycardScientist);
                            response = "Предмет успешно удален";
                            return true;
                        case ItemType.KeycardZoneManager:
                            scp.Points = ((int)PointsForItems.PointsKeycardZoneManager);
                            response = "Предмет успешно удален";
                            return true;
                        case ItemType.KeycardGuard:
                            scp.Points = ((int)PointsForItems.PointsKeycardGuard);
                            response = "Предмет успешно удален";
                            return true;
                        case ItemType.KeycardNTFOfficer:
                            scp.Points = ((int)PointsForItems.PointsKeycardLieutenant);
                            response = "Предмет успешно удален";
                            return true;
                        case ItemType.KeycardNTFLieutenant:
                            scp.Points = ((int)PointsForItems.PointsKeycardLieutenant);
                            response = "Предмет успешно удален";
                            return true;
                        case ItemType.KeycardNTFCommander:
                            scp.Points = ((int)PointsForItems.PointsKeycardCapitan);
                            response = "Предмет успешно удален";
                            return true;
                        case ItemType.KeycardChaosInsurgency :
                            scp.Points = ((int)PointsForItems.PointsKeycardChaosInsurgency);
                            response = "Предмет успешно удален";
                            return true;
                        case ItemType.KeycardFacilityManager:
                            scp.Points = ((int)PointsForItems.PointsKeycardManager);
                            response = "Предмет успешно удален";
                            return true;
                        case ItemType.KeycardO5:
                            scp.Points = ((int)PointsForItems.PointsKeycardO5);
                            response = "Предмет успешно удален";
                            return true;

                        //Оружие 
                        case ItemType.GunCOM15:
                            scp.Points = ((int)PointsForItems.PointsCOM15);
                            response = "Предмет успешно удален";
                            return true;
                        case ItemType.GunCOM18:
                            scp.Points = ((int)PointsForItems.PointsCOM18);
                            response = "Предмет успешно удален";
                            return true;
                        case ItemType.GunFSP9:
                            scp.Points = ((int)PointsForItems.PointsFSP9);
                            response = "Предмет успешно удален";
                            return true;
                        case ItemType.GunCrossvec:
                            scp.Points = ((int)PointsForItems.PointsCrossvec);
                            response = "Предмет успешно удален";
                            return true;
                        case ItemType.GunE11SR:
                            scp.Points = ((int)PointsForItems.PointsE11_SR);
                            response = "Предмет успешно удален";
                            return true;
                        case ItemType.GunLogicer:
                            scp.Points = ((int)PointsForItems.PointsLogicer);
                            response = "Предмет успешно удален";
                            return true;
                        case ItemType.MicroHID:
                            scp.Points = ((int)PointsForItems.PointsMicroHID);
                            response = "Предмет успешно удален";
                            return true;
                        default:
                            response = "Error";
                            return false;
                            
                    }

                }
                response = "У вас есть доступ к данной комманде";
                return true;
            }
            else 
            {
                Exiled.API.Features.Log.Info(player + scp.players1956List.ToString());
                response = "У вас нету доступа к данной комманде";
                return false;
            }
        }
    }
}
