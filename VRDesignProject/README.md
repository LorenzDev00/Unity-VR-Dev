# VR Project: **Spaceship Evacuation Simulation** 🚀

**Objective**:  
Escape from a drifting, soon-to-be-destroyed spaceship by solving puzzles and overcoming obstacles to reach the emergency escape pod.

- **Environment Design**:
  - **Setting**: Sci-fi spaceship in a critical emergency
  - **Lighting**: 
    - ⚠️ *Red emergency lights*
    - 💡 *Flickering and broken white lights with electrical sparks*
    - 🔥 *Occasional flames*
  - **Sound Design**: 
    - 🚨 *Alarms and explosions*
    - 🎙️ *Emergency voice instructions in a loop*
  
- **Movement & Interaction**:
  - **Movement**: WASD + QE keys for navigation
  - **Active Interaction**: 
    - Use keys **T/Y** for left/right hand interaction 
    - **Raycast** for object focus
    - **G key** to grab/use objects
  - **Passive Interaction**: Auto-trigger events by entering object colliders
  - **Menu Interaction**: 
    - Access **M** for options (*resume*, *how-to*, *quit*)  
    - Hands interaction needed to use menu
  
- **Teleportation**:  
  Activate by focusing on specific tiles on the floor (marked with white lights) and pressing **G**.

- **Animated Objects**:  
  - 🤖 *Android* (salutes & indicates direction)
  - 🔧 *Maintenance robot* (patrols corridors)

- **Scenes**:
  1. **Crew Quarters**:
     - Interactive objects: doors, android, pistols, crates  
  2. **Escape Section**:
     - Solve puzzle by placing **batteries** to open the **evacuation door**
     - Simulation ends upon reaching the **escape doors**
