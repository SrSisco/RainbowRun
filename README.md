# RainbowRun

![downloads](https://img.shields.io/github/downloads/SrSisco/RainbowRun/total?style=for-the-badge)

## About
A plugin that runs an event called RainbowRun.
In this events, a lot of actions trigger random events that will transform
the game into a complete chaotic mess.

Some of these events are: size changing, health changing, random TP, 
swapping players, spawning dead players, changing roles...

EXILED VERSION: 8.8.0

## Commands

**Client Console**  
.activateRR : runs the RainbowRun event 

## Default Config
```yaml
rainbow_run:
# Is the plugin enabled
  is_enabled: true
  # Is debug enabled
  debug: false
  # Wether the plugin is actively working
  is_active: false
  # IWether the plugin should be inactive after round end
  deactivate_on_round_end: true
  # Trigger events when interacting with doors
  door_events: true
  # Trigger events when interacting with elevators
  elevator_events: true
  # Trigger events when interacting with lockers
  locker_events: true
  # Trigger events when interacting with doors
  tesla_events: true
  # Trigger events when shooting
  shot_events: true
  # Trigger events when using items
  using_item_events: true
  # Trigger events when interacting with doors
  dropping_item_events: true
  # Restart server event is enabled?
  server_restart_event: true
  # Restart event difficulty (0-10000), 0 = 100% 10000 = 0%
  server_restart_probability: 9999
  # Changing player size event is enabled?
  reseize_event: true
  # How much can the size change (default size is 1,1,1)
  reseize_factor: 0.5
  # Reseize event difficulty (0-100), 0 = 100% 100 = 0%
  reseize_probability: 99
  # Changing player health event is enabled?
  health_event: true
  # How much can the health change?
  health_factor: 0.5
  # Health event difficulty (0-100), 0 = 100% 100 = 0%
  health_probability: 90
  # Swapping players position event is enabled?
  swapping_players_event: true
  # Health event difficulty (0-100), 0 = 100% 100 = 0%
  swapping_players_probability: 95
  # Spawning grenade/flash/018 event is enabled?
  grenade_event: true
  # Spawning greande/flash/018 event difficulty (0-100), 0 = 100% 100 = 0%
  grenade_probability: 95
  # Spawning dead players event is enabled?
  spawning_players_event: true
  # Health event difficulty (0-100), 0 = 100% 100 = 0%
  spawning_players_probability: 95
  # Teleporting players to random rooms event is enabled?
  room_t_p_event: true
  # Teleporting players to random rooms event difficulty (0-100), 0 = 100% 100 = 0%
  room_t_p_probability: 95
  # Give effect event is enabled?
  effect_event: true
  # Give effect event difficulty (0-100), 0 = 100% 100 = 0%
  effect_probability: 95
  # Teleporting players to random rooms event is enabled?
  give_item_event: true
  # Teleporting players to random rooms event difficulty (0-100), 0 = 100% 100 = 0%
  give_item_probability: 95
  # Changing role event is enabled?
  change_role_event: true
  # Changing role event difficulty (0-100), 0 = 100% 100 = 0%
  change_role_probability: 95

```
