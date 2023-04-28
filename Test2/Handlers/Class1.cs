using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Exiled.API.Features;
using static Test2.Config;
using System.Reflection;
using InventorySystem.Items.Pickups;
using Exiled.API.Features.Roles;
using PlayerRoles;
using System.Security.Policy;
using Exiled.Events.EventArgs.Player;
using PlayerRoles.PlayableScps.Scp939.Ripples;
using Exiled.API.Features.Pickups;
using PlayerStatsSystem;

namespace Test2.Handlers
{
    internal class Class1 : MonoBehaviour
    {
        private string cassie;
        private void OnTriggerEnter(Collider other)
        {


            
            if (other.GetComponentInParent<ItemPickupBase>())
            {
                var pickup = other.GetComponentInParent<ItemPickupBase>();
                switch (pickup.Info.ItemId)
                {
                    case ItemType.SCP500:
                        cassie = "cassie SCP 5 0 0 has been evacuated by";
                        break;
                    case ItemType.SCP330:
                        cassie = "cassie SCP 3 3 0 has been evacuated by";
                        break;
                    case ItemType.SCP268:
                        cassie = "cassie SCP 2 6 0 has been evacuated by";
                        break;
                    case ItemType.SCP244b:
                        cassie = "cassie SCP 2 4 4 B has been evacuated by";
                        break;
                    case ItemType.SCP244a:
                        cassie = "cassie SCP 2 4 4 A has been evacuated by";
                        break;
                    case ItemType.SCP2176:
                        cassie = "cassie SCP 2 1 7 6 has been evacuated by";
                        break;
                    case ItemType.SCP207:
                        cassie = "cassie SCP 2 0 7 has been evacuated by";
                        break;
                    case ItemType.SCP1853:
                        cassie = "cassie SCP 1 8 5 3 has been evacuated by";
                        break;
                    case ItemType.SCP1576:
                        cassie = "cassie SCP 1 5 7 6 has been evacuated by";
                        break;
                    case ItemType.SCP018:
                        cassie = "cassie SCP 0 1 8 has been evacuated by";
                        break;
                    default:
                        break;
                }
               
                if(!string.IsNullOrEmpty(cassie))
                {
                    var cas = cassie;
                    cassie = "";
                    var pickupobjdel = Pickup.Get(pickup);
                    if (pickup.PreviousOwner.Role == RoleTypeId.ChaosConscript || pickup.PreviousOwner.Role == RoleTypeId.ChaosMarauder || pickup.PreviousOwner.Role == RoleTypeId.ChaosRepressor || pickup.PreviousOwner.Role == RoleTypeId.ChaosRifleman)
                    {
                        Cassie.Message(cas + " ChaosInsurgency . . .g1");
                        Log.Info("d");
                        pickupobjdel.Destroy();
                    }
                    else if (pickup.PreviousOwner.Role == RoleTypeId.NtfCaptain || pickup.PreviousOwner.Role == RoleTypeId.NtfSpecialist || pickup.PreviousOwner.Role == RoleTypeId.NtfSergeant || pickup.PreviousOwner.Role == RoleTypeId.NtfPrivate)
                    {
                        Cassie.Message(cas + " MtfUnit Epsilon 11 . . .g1");
                        pickupobjdel.Destroy();
                        
                    }
                }
                
            }
        }
    }
}
