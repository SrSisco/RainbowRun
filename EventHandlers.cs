
using System;
using System.Linq;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.API.Features.Pickups.Projectiles;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Server;
using PlayerRoles;
using UnityEngine;
using Random = UnityEngine.Random;

namespace RainbowRun
{ 
     
    public class EventHandlers
    {
        
        //List of events that can be execute when the player does something
        private void Events(Player pl)
        {
            if (RainbowRun.Instance.Config.IsActive == false)
                return;
            
            //Restarting the server event
            if (RainbowRun.Instance.Config.ServerRestartEvent 
                && Random.Range(0, 10000) > RainbowRun.Instance.Config.ServerRestartProbability)
            {
                Server.Restart();
            }

            
            //Changing player scale event
            if (RainbowRun.Instance.Config.ReseizeEvent 
                && Random.Range(0,100) > RainbowRun.Instance.Config.ReseizeProbability)
            {
                var fac = RainbowRun.Instance.Config.ReseizeFactor;
                var xdiff = Random.Range(fac * -1, fac);
                var ydiff = Random.Range(fac * -1, fac);
                var zdiff = Random.Range(fac * -1, fac);

                pl.Scale.Set(pl.Scale.x + xdiff, pl.Scale.y + ydiff, pl.Scale.z + zdiff);
            }


            //Changing player health event
            if (RainbowRun.Instance.Config.HealthEvent 
                && Random.Range(0, 100) > RainbowRun.Instance.Config.HealthProbability)
            {
                var fac = RainbowRun.Instance.Config.HealthFactor;
                var healthdiff = Random.Range(-1*fac, fac);
                
                pl.Health += healthdiff;
            }

            
            //Swapping two players' position event
            if (RainbowRun.Instance.Config.SwappingPlayersEvent 
                &&Random.Range(0, 100) > RainbowRun.Instance.Config.SwappingPlayersProbability)
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

            
            //Spawning an active grenade event
            if (RainbowRun.Instance.Config.GrenadeEvent 
                && Random.Range(0, 100) > RainbowRun.Instance.Config.GrenadeProbability)
            {
                var grenadetype = Random.Range(0, 2);
                
                switch (grenadetype)
                {
                    case 0:
                        ExplosiveGrenade grenade1 = (ExplosiveGrenade)Item.Create(ItemType.GrenadeHE);
                        ExplosionGrenadeProjectile activeGrenade1 = grenade1.SpawnActive(pl.Position);
                        break;
                    case 1:
                        ExplosiveGrenade grenade2 = (ExplosiveGrenade)Item.Create(ItemType.GrenadeFlash);
                        ExplosionGrenadeProjectile activeGrenade2 = grenade2.SpawnActive(pl.Position);
                        break;
                    case 2:
                        ExplosiveGrenade grenade3 = (ExplosiveGrenade)Item.Create(ItemType.SCP018);
                        ExplosionGrenadeProjectile activeGrenade3 = grenade3.SpawnActive(pl.Position);
                        break;
                }


            }

            
            //Spawning dead players event
            if (RainbowRun.Instance.Config.SpawningPlayersEvent 
                && Random.Range(0, 100) > RainbowRun.Instance.Config.SpawningPlayersProbability)
            {
                var a = Player.List.Where(x => x.Role == RoleTypeId.Spectator)
                    .ToList().RandomItem();
                
                a.Role.Set(RainbowRun.Instance.Config.RolesDisponibles[
                    Random.Range(0,RainbowRun.Instance.Config.RolesDisponibles.Count)]);
                
                
            }
            
            
            //Teleporting player to a random room event
            if (RainbowRun.Instance.Config.RoomTPEvent 
                && Random.Range(0, 100) > RainbowRun.Instance.Config.RoomTPProbability)
            {
                var habitacion = Room.Random().Position;
                
                pl.Teleport(new Vector3(habitacion.x,habitacion.y +1f,habitacion.z));
            }
            
            
            //Giving random effect to player event
            if (RainbowRun.Instance.Config.EffectEvent 
                && Random.Range(0, 100) > RainbowRun.Instance.Config.EffectProbability)
            {
                pl.EnableEffect(
                    RainbowRun.Instance.Config.EfectosDisponibles[
                        Random.Range(0, RainbowRun.Instance.Config.EfectosDisponibles.Count)],Byte.MaxValue,Random.Range(1,40),true);
            }
            
            
            //Giving random item to player event
            if (RainbowRun.Instance.Config.GiveItemEvent 
                && Random.Range(0, 100) > RainbowRun.Instance.Config.GiveItemProbability)
            {
                pl.AddItem(
                    RainbowRun.Instance.Config.ItemsDisponibles[
                        Random.Range(0, RainbowRun.Instance.Config.RolesDisponibles.Count)]);
            }
            
            
            //Chaning random role to player event
            if (RainbowRun.Instance.Config.ChangeRoleEvent 
                && Random.Range(0, 100) > RainbowRun.Instance.Config.ChangeRoleProbability)
            {
                pl.Role.Set(
                    RainbowRun.Instance.Config.RolesDisponibles[
                        Random.Range(0,RainbowRun.Instance.Config.RolesDisponibles.Count)], SpawnReason.ForceClass, RoleSpawnFlags.None);
            }
            
        }
        
        
        //Execute events when interacting with doors
        public void OnInteractingDoor(InteractingDoorEventArgs ev)
        {
            if(RainbowRun.Instance.Config.DoorEvents)
                Events(ev.Player);
             
        }

        
        //Execute events when iteracting with elevators
        public void OnInteractingElevator(InteractingElevatorEventArgs ev)
        {
            if(RainbowRun.Instance.Config.ElevatorEvents)
                Events(ev.Player);
        }
        
        
        //Execute events when interacting with lockers
        public void OnInteractingLocker(InteractingLockerEventArgs ev)
        {
            if(RainbowRun.Instance.Config.LockerEvents)
                Events(ev.Player);
        }

        
        //Execute events when triggering a tesla gate
        public void OnTriggeringTesla(TriggeringTeslaEventArgs ev)
        {
            if(RainbowRun.Instance.Config.TeslaEvents)
                Events(ev.Player);
        }
        
        
        //Execute events when shooting
        public void OnShot(ShotEventArgs ev)
        {
            if(RainbowRun.Instance.Config.ShotEvents)
                Events(ev.Player);
        }
        
        
        //Execute events when using items
        public void OnUsingItem(UsingItemEventArgs ev)
        {
            if(RainbowRun.Instance.Config.UsingItemEvents)
                Events(ev.Player);
        }

        
        //Execute events when dropping items
        public void OnDroppingItem(DroppingItemEventArgs ev)
        {
            if (RainbowRun.Instance.Config.DroppingItemEvents)
                Events(ev.Player);
        }
        
        
        //Execute at round end

        public void OnRoundEnded(RoundEndedEventArgs ev)
        {
            if (RainbowRun.Instance.Config.IsActive 
                &&RainbowRun.Instance.Config.DeactivateOnRoundEnd)
                RainbowRun.Instance.Config.IsActive = false;
        }
    }
}