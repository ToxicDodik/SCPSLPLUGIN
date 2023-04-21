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

namespace Test2.Handlers
{
    public class Player
    {
        private List<Exiled.API.Features.Player> playerlist = scp1956.players1956List;
        public void OnJoined(JoinedEventArgs ev)
        {
            ev.Player.Broadcast(500, "lox");
        }
        public void OnLeft(LeftEventArgs ev)
        {
            Map.Broadcast(6, $"{ev.Player} has left..");

            playerlist.Remove(ev.Player);

        }
        public void OnDeath(DiedEventArgs ev)
        {
      
            ev.Player.Scale = new UnityEngine.Vector3(1, 1, 1);
            playerlist.Remove(ev.Player);

        }

    }
}