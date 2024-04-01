namespace RainbowRun
{
    using Exiled.API.Features;
    using System;
    using Server = Exiled.Events.Handlers.Server;
    using Player = Exiled.Events.Handlers.Player;
    public class RainbowRun : Plugin<Config>
    {
        public override string Name => "RainbowRun";
        public override string Author => "srsisco";
        public override Version Version => new Version(1, 0, 4);

        public static RainbowRun Instance;
        public EventHandlers _handlers;

        public override void OnEnabled()
        {
            Instance = this;
            _handlers = new EventHandlers();

            Player.InteractingDoor += _handlers.OnInteractingDoor;
            Player.Shot += _handlers.OnShot;
            Player.UsingItem += _handlers.OnUsingItem;
            Player.InteractingElevator += _handlers.OnInteractingElevator;
            Player.InteractingLocker += _handlers.OnInteractingLocker;
            Player.TriggeringTesla += _handlers.OnTriggeringTesla;
            Player.DroppingItem += _handlers.OnDroppingItem;
            Server.RoundEnded += _handlers.OnRoundEnded;
            
            Log.Info("RainbowRun has been enabled");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            
            Player.InteractingDoor -= _handlers.OnInteractingDoor;
            Player.Shot -= _handlers.OnShot;
            Player.UsingItem -= _handlers.OnUsingItem;
            Player.InteractingElevator -= _handlers.OnInteractingElevator;
            Player.InteractingLocker -= _handlers.OnInteractingLocker;
            Player.TriggeringTesla -= _handlers.OnTriggeringTesla;
            Player.DroppingItem -= _handlers.OnDroppingItem;
            Server.RoundEnded -= _handlers.OnRoundEnded;
            _handlers = null;
            Instance = null;
            Log.Info("RainbowRun has been disabled");
            base.OnDisabled();
        }
    }
}