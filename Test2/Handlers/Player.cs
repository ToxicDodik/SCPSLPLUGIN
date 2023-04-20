using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs.Player;
using InventorySystem.Items.Keycards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Assertions.Must;
using static Test2.scp1956;

namespace Test2.Handlers
{
    public class Player
    {
        scp1956 scp = new scp1956();
        public void OnJoined(JoinedEventArgs ev)
        {
            ev.Player.Broadcast(500, "lox");
        }
        public void OnLeft(LeftEventArgs ev)
        {
            Map.Broadcast(6, $"{ev.Player} has left..");

            Exiled.API.Features.Player player = ev.Player;
            scp.players1956List.Remove(player);

        }
        public void OnDeath(DiedEventArgs ev)
        {
      
            ev.Player.Scale = new UnityEngine.Vector3(1, 1, 1);
            Exiled.API.Features.Player player = ev.Player;
            scp.players1956List.Remove(player);

        }

    }
}