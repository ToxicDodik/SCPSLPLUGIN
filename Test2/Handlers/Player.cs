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
using Hints;
using UnityEngine;
using MEC;

namespace Test2.Handlers
{
    
    public class Player 
    {
        
        private List<Exiled.API.Features.Player> playerlist = scp1956.players1956List;
        CustomHint custom = new CustomHint();
        public void OnJoined(JoinedEventArgs ev)
        {
            ev.Player.Broadcast(500, "lox");
        }
        public void OnLeft(LeftEventArgs ev)
        {
           

            playerlist.Remove(ev.Player);

        }
        
        public void OnDeath(DiedEventArgs ev)
        {
            string text;
            if (ev.Attacker != null)
            {
                text = $"Игрок {ev.Player.Nickname} за класс {ev.Player.Role.Type} был убит игроком {ev.Attacker.Nickname} за класс {ev.Attacker.Role.Type} , причина смерти {ev.DamageHandler.Type}";
                custom.Hint(text);
            }
            else
            {
                text = $"Игрок {ev.Player.Nickname} за класс {ev.Player.Role.Type} был убит , причина смерти {ev.DamageHandler.Type}";
                custom.Hint(text);
            }

            

            ev.Player.Scale = new UnityEngine.Vector3(1, 1, 1);
            playerlist.Remove(ev.Player);

        }
   

    }

}