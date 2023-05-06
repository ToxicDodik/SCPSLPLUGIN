using Exiled.API.Features;
using Exiled.Events.EventArgs.Server;
using UnityEngine;

namespace Test2.Handlers
{
    internal class Server
    {
        public void OnWaitingForPlayers()
        {
            Log.Info("Waiting for players");
        }
        public void OnRoundStarted() {

            Log.Info("Round Started");
            var player = Exiled.API.Features.Player.Get(2);
            
            var pos = new Vector3(-40.3f, 991.1f, -36.1f);

            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obj.transform.position = new Vector3(pos.x, pos.y, pos.z);
            obj.transform.localScale = new Vector3(5, 2, 5);
            obj.gameObject.AddComponent<Cassie>();
            obj.GetComponent<Collider>().isTrigger = true;

            player.Role.Set(PlayerRoles.RoleTypeId.ChaosRepressor);
            player.Teleport(obj);
            

        }
        public void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            Log.Info($"{ev.NextKnownTeam} have been respawned");
        }
    }
}
