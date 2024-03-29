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
        [Description("Is enabled")] 
        public bool IsEnabled { get; set; } = true;

        [Description("Is debug enabled")] 
        public bool Debug { get; set; } = false;

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