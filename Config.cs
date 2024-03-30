using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Enums;
using Exiled.API.Features.Items;
using Exiled.API.Interfaces;
using PlayerRoles;

namespace RainbowRun
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled")] 
        public bool IsEnabled { get; set; } = true;

        [Description("Is debug enabled")] 
        public bool Debug { get; set; } = false;
        
        [Description("Wether the plugin is actively working")] 
        public bool IsActive { get; set; } = false;
        
        [Description("IWether the plugin should be inactive after round end")] 
        public bool DeactivateOnRoundEnd { get; set; } = true;
        
        //------------------- ENABLED EVENTS --------------------
        
        [Description("Trigger events when interacting with doors")]
        public bool DoorEvents { get; set; } = true;
        
        
        
        [Description("Trigger events when interacting with elevators")]
        public bool ElevatorEvents { get; set; } = true;
        
        
        
        [Description("Trigger events when interacting with lockers")]
        public bool LockerEvents { get; set; } = true;
        
        
        
        [Description("Trigger events when interacting with doors")]
        public bool TeslaEvents { get; set; } = true;
        
        
        
        [Description("Trigger events when shooting")]
        public bool ShotEvents { get; set; } = true;
        
        
        
        [Description("Trigger events when using items")]
        public bool UsingItemEvents { get; set; } = true;
        
        
        
        [Description("Trigger events when interacting with doors")]
        public bool DroppingItemEvents { get; set; } = true;
        
        
        
        
        // ------------------------ ACTIVATE EVENTS ----------------------
        
        [Description("Restart server event is enabled?")]
        public bool ServerRestartEvent { get; set; } = true;
        
        [Description("Restart event difficulty (0-10000), 0 = 100% 10000 = 0%")]
        public int ServerRestartProbability { get; set; } = 9999;
        
        
        
        [Description("Changing player size event is enabled?")]
        public bool ReseizeEvent { get; set; } = true;
        
        [Description("How much can the size change (default size is 1,1,1)")]
        public float ReseizeFactor { get; set; } = 0.5f;
        
        [Description("Reseize event difficulty (0-100), 0 = 100% 100 = 0%")]
        public int ReseizeProbability { get; set; } = 99;
        
         
        
        [Description("Changing player health event is enabled?")]
        public bool HealthEvent { get; set; } = true;
        
        [Description("How much can the health change?")]
        public float HealthFactor { get; set; } = 0.5f;
        
        [Description("Health event difficulty (0-100), 0 = 100% 100 = 0%")]
        public int HealthProbability { get; set; } = 90;
        
        
        
        [Description("Swapping players position event is enabled?")]
        public bool SwappingPlayersEvent { get; set; } = true;
        
        [Description("Health event difficulty (0-100), 0 = 100% 100 = 0%")]
        public int SwappingPlayersProbability { get; set; } = 95;
        
        
        
        [Description("Spawning grenade/flash/018 event is enabled?")]
        public bool GrenadeEvent { get; set; } = true;
        
        [Description("Spawning greande/flash/018 event difficulty (0-100), 0 = 100% 100 = 0%")]
        public int GrenadeProbability { get; set; } = 95;
        
        
        
        [Description("Spawning dead players event is enabled?")]
        public bool SpawningPlayersEvent { get; set; } = true;
        
        [Description("Health event difficulty (0-100), 0 = 100% 100 = 0%")]
        public int SpawningPlayersProbability { get; set; } = 95;
        
        
        
        [Description("Teleporting players to random rooms event is enabled?")]
        public bool RoomTPEvent { get; set; } = true;
        
        [Description("Teleporting players to random rooms event difficulty (0-100), 0 = 100% 100 = 0%")]
        public int RoomTPProbability { get; set; } = 95;
        
        
        
        [Description("Give effect event is enabled?")]
        public bool EffectEvent { get; set; } = true;
        
        [Description("Give effect event difficulty (0-100), 0 = 100% 100 = 0%")]
        public int EffectProbability { get; set; } = 95;
        
        
        
        [Description("Teleporting players to random rooms event is enabled?")]
        public bool GiveItemEvent { get; set; } = true;
        
        [Description("Teleporting players to random rooms event difficulty (0-100), 0 = 100% 100 = 0%")]
        public int GiveItemProbability { get; set; } = 95;
        
        
        
        [Description("Changing role event is enabled?")]
        public bool ChangeRoleEvent { get; set; } = true;
        
        [Description("Changing role event difficulty (0-100), 0 = 100% 100 = 0%")]
        public int ChangeRoleProbability { get; set; } = 95;
        
        
        
        
        //---------------- LISTS -------------------
        
        public List<RoleTypeId> RolesDisponibles = new List<RoleTypeId>()
        {
            RoleTypeId.Scp049,RoleTypeId.Scp096,RoleTypeId.Scp096,RoleTypeId.Scp106,
            RoleTypeId.Scp173,RoleTypeId.Scp0492,RoleTypeId.Scp939,RoleTypeId.Scp3114, RoleTypeId.Tutorial, 
            RoleTypeId.ChaosConscript, RoleTypeId.ClassD, RoleTypeId.NtfCaptain, RoleTypeId.NtfPrivate,
            RoleTypeId.Scientist,RoleTypeId.Scientist,RoleTypeId.Scientist, RoleTypeId.ClassD,RoleTypeId.ClassD,
            RoleTypeId.ClassD,RoleTypeId.ClassD,RoleTypeId.ClassD
        };

        public List<ItemType> ItemsDisponibles = new List<ItemType>()
        {
            ItemType.Adrenaline, ItemType.Ammo9x19, ItemType.Ammo12gauge, ItemType.Ammo44cal,
            ItemType.Ammo556x45, ItemType.Ammo762x39, ItemType.Coin, ItemType.Flashlight,
            ItemType.Jailbird, ItemType.Medkit, ItemType.ArmorCombat, ItemType.ArmorHeavy,
            ItemType.GunA7, ItemType.KeycardO5, ItemType.KeycardChaosInsurgency, ItemType.KeycardMTFOperative,
            ItemType.SCP244a, ItemType.SCP500, ItemType.SCP018,ItemType.SCP207,ItemType.SCP268,ItemType.SCP330,
            ItemType.SCP1576,ItemType.SCP2176,ItemType.AntiSCP207,ItemType.GunRevolver,ItemType.GunCrossvec,ItemType.GunRevolver,
            ItemType.GunCOM15,ItemType.GunCOM18,ItemType.GunE11SR,ItemType.GunFRMG0
        };

        public List<EffectType> EfectosDisponibles = new List<EffectType>()
        {
            EffectType.Asphyxiated,EffectType.Bleeding,EffectType.Blinded,EffectType.Burned,EffectType.Concussed
            ,EffectType.Corroding,EffectType.Deafened,EffectType.Decontaminating,EffectType.Disabled,EffectType.Ensnared,
            EffectType.Exhausted,EffectType.Flashed,EffectType.Hemorrhage,EffectType.Hypothermia,EffectType.Invigorated,EffectType.Invisible,
            EffectType.Poisoned,EffectType.Scp207,EffectType.Scp1853,EffectType.AntiScp207,EffectType.Strangled,EffectType.Traumatized,
            EffectType.Vitality,EffectType.AmnesiaItems,EffectType.AmnesiaVision,EffectType.CardiacArrest,EffectType.DamageReduction,
            EffectType.InsufficientLighting,EffectType.SeveredHands,EffectType.SinkHole
        };
        
    }
}