# EncounterZoneNames

Adds encounter zone levels to cell names and map markers — so you know what you're walking into!

## What does this patcher do?

This patcher injects **encounter zone levels** into cell and/or map marker names across your load order. You’ll get a heads-up on how strong enemies will be *before* entering a location — no more getting steamrolled by surprise deathtraps.

Examples (vanilla zones):  
- Embershard Mine → **Embershard Mine (Levels 6 to 10)**  
- Forelhost → **Forelhost (Level 24+)**

---

### What are Encounter Zones?

*TL;DR: They control enemy level scaling — knowing them means smarter exploration.*

Each location in Skyrim has an *encounter zone* with a minimum (and sometimes max) level. That zone determines enemy strength:

- Enemies scale with you **within** the zone’s level range.
- **Below** the min level? Enemies still meet that min.
- **Above** the max? They stop scaling and stay capped.

So Embershard Mine (6–10) is tough at level 1 but a cakewalk at level 20.  
Forelhost, with a min level of 24 and no cap, will happily kick your level 5 teeth in.

### Why does this matter?

Because right now, nothing warns you. You just walk into Forelhost thinking “cool, a Nordic ruin,” and get *obliterated* by super-Draugr. This patcher fixes that.

### What this patcher actually does

It shows you the enemy level range for each zone **before** you enter, either:
- In the location name when you enter the cell
- On the world map via map markers

No surprises. No early deaths. Just informed dungeon-diving.

---

## Recommended Mods

Pair this with [Encounter Zone Informer](https://www.nexusmods.com/skyrimspecialedition/mods/124456 "Encounter Zone Informer") for in-game pop-up warnings, or mods that improve zone design like [OWL](https://www.nexusmods.com/skyrimspecialedition/mods/49681 "OWL") and [MorrowLoot](https://www.nexusmods.com/skyrimspecialedition/mods/3058?tab=description "MorrowLoot").

---

## Acknowledgments

This patcher is a modernized Synthesis update of:  
- [Cell Encounter Levels in Name](https://www.nexusmods.com/skyrimspecialedition/mods/4024) by hishutup  
- [UPF Patcher – See the Encounter Zone level in the name of the zone](https://www.nexusmods.com/skyrimspecialedition/mods/19881/) by mickthompson4000

Thanks to both for the original ideas and code inspiration!
