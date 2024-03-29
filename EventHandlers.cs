
using System;
using System.Linq;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.API.Features.Pickups.Projectiles;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Scp079;
using MEC;
using PlayerRoles;
using UnityEngine;
using Random = UnityEngine.Random;

namespace RainbowRun
{
    
    public class EventHandlers
    {
        private void givethings(Player pl)
        {
            if (Random.Range(0, 5000) > 4999)
            {
                Server.Restart();
            }
            if(Random.Range(0,100) > 99)
            {
                var xdiff = Random.Range(-0.7f, 0.7f);
                var ydiff = Random.Range(-0.7f, 0.7f);
                var zdiff = Random.Range(-0.7f, 0.7f);

                pl.Scale = new Vector3(pl.Scale.x + xdiff, pl.Scale.y + ydiff, pl.Scale.z + zdiff);
                
            }

            if (Random.Range(0, 100) > 80)
            {
                var healthdiff = Random.Range(-100, 100);
                pl.Health += healthdiff;
                
            }
            if (Random.Range(0, 100) > 97)
            {
                
                var player2 = Player.List.ToList().RandomItem();
                if (player2.Role != RoleTypeId.None && player2.Role != RoleTypeId.Spectator &&
                    player2.Role != RoleTypeId.Filmmaker && player2.Role != RoleTypeId.Overwatch)
                {
                    var player2pos = player2.Position;
                    player2.Position = pl.Position;
                    pl.Position = player2pos;
                }
                
            }

            if (Random.Range(0, 100) > 98)
            {
                var a = Random.Range(0, 2);
                switch (a)
                {
                    case 0:
                        ExplosiveGrenade grenade1 = (ExplosiveGrenade)Item.Create(ItemType.GrenadeHE);
                        ExplosionGrenadeProjectile granadaActiva1 = grenade1.SpawnActive(pl.Position);
                        break;
                    case 1:
                        ExplosiveGrenade grenade2 = (ExplosiveGrenade)Item.Create(ItemType.GrenadeFlash);
                        ExplosionGrenadeProjectile granadaActiva2 = grenade2.SpawnActive(pl.Position);
                        break;
                    case 2:
                        ExplosiveGrenade grenade3 = (ExplosiveGrenade)Item.Create(ItemType.SCP018);
                        ExplosionGrenadeProjectile granadaActiva3 = grenade3.SpawnActive(pl.Position);
                        break;
                }


            }

            if (Random.Range(0, 100) > 98)
            {
                var a = Player.List.Where(x => x.Role == RoleTypeId.Spectator).ToList().RandomItem();
                a.Role.Set(RainbowRun.Instance.Config.RolesDisponibles[
                    Random.Range(0,RainbowRun.Instance.Config.RolesDisponibles.Count)]);
            }
            if (Random.Range(0, 100) > 97)
            {
                var habitacion = Room.Random().Position;
                pl.Teleport(new Vector3(habitacion.x,habitacion.y +1f,habitacion.z));
            }
            if (Random.Range(0, 100) > 95)
            {
                pl.EnableEffect(
                    RainbowRun.Instance.Config.EfectosDisponibles[
                        Random.Range(0, RainbowRun.Instance.Config.EfectosDisponibles.Count)],Byte.MaxValue,Random.Range(1,40),true);
            }
            if (Random.Range(0, 100) > 90)
            {
                pl.AddItem(
                    RainbowRun.Instance.Config.ItemsDisponibles[
                        Random.Range(0, RainbowRun.Instance.Config.RolesDisponibles.Count)]);
            }
            if (Random.Range(0, 100) > 98)
            {
                pl.Role.Set(
                    RainbowRun.Instance.Config.RolesDisponibles[
                        Random.Range(0,RainbowRun.Instance.Config.RolesDisponibles.Count)], SpawnReason.ForceClass, RoleSpawnFlags.None);
            }
        }
        
        public void OnInteractingDoor(InteractingDoorEventArgs ev)
        {
            givethings(ev.Player);
             
        }

        public void OnInteractingElevator(InteractingElevatorEventArgs ev)
        {
            givethings(ev.Player);
        }
        public void OnInteractingLocker(InteractingLockerEventArgs ev)
        {
            givethings(ev.Player);
        }

        public void OnTriggeringTesla(TriggeringTeslaEventArgs ev)
        {
            
            var coca = Random.Range(0, 100);
            if (coca > 98)
            {

                ev.Tesla.Trigger();
                ev.Tesla.Trigger(true);
                ev.Tesla.Trigger(true);
                ev.Tesla.Trigger(true);
                ev.Tesla.Trigger(true);
            }
            else if (coca < 20)
            {
                ev.IsAllowed = false;
            }
        }
        
        public void OnDamagingShootingTarget(DamagingShootingTargetEventArgs ev)
        {
            givethings(ev.Player);
        }

        public void OnShot(ShotEventArgs ev)
        {
            givethings(ev.Player);
        }
        
        public void OnUsingItem(UsingItemEventArgs ev)
        {
            givethings(ev.Player);
        }
        
        
    }
}