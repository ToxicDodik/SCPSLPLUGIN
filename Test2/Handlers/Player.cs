using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Test2.Handlers
{
    public class Player
    {

        public void OnJoined(JoinedEventArgs ev)
        {
            ev.Player.Broadcast(500, "lox");
        }
        public void OnLeft(LeftEventArgs ev)
        {
            Map.Broadcast(6, $"{ev.Player} has left..");
        }
        public void OnDeath(DiedEventArgs ev)
        {
            ev.Player.Scale = new UnityEngine.Vector3(1, 1, 1);
        }

    }
}