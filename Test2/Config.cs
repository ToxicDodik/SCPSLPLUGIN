using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; }
        public enum PointsForItems : int
        {
            PointsKeycardJanitor = 5,
            PointsKeycardScientist = 10,
            PointsKeycardZoneManager = 15,
            PointsKeycardGuard = 20,
            PointsKeycardOfficer = 50,
            PointsKeycardLieutenant = 60,
            PointsKeycardCapitan = 80,
            PointsKeycardChaosInsurgency = 80,
            PointsKeycardManager = 90,
            PointsKeycardO5 = 100,
            
            PointsCOM15 = 10,
            PointsCOM18 = 10,
            PointsFSP9 = 30,
            PointsCrossvec = 40,
            PointsE11_SR = 50,
            PointsLogicer = 100,

            PointsMicroHID = 200,

            PointsAdrenaline = 60,
            PointsFlashlight = 70,
            PointsRadio = 20,
            PointsSCP018 = 170,
            PointsSCP207 = 180,
            PointsSCP268 = 250,
            PointsSCP500 = 190,
        }
    }
}
