# EncounterZoneNames

Adds encounter zone levels to cell names and map markers, so you know what you're walking into!

## What does this patcher do?

This patcher adds** encounter zone levels** to the names of all cells and/or map markers in your load order, and allows you some customization of how these levels show up. This lets you **know how strong enemies will be *before* entering a location** - say goodbye to getting instantly melted because you entered a high-level zone without knowing!

Examples for vanilla encounter zones: 
Embershard Mine -> **Embershard Mine (Levels 6 to 10)**
Forelhost -> **Forelhost (Level 24+)**

------------

### What are 'Encounter Zones'? Why should I care?

*TL;DR: Encounter zones control enemy level scaling, and it's much nicer to know what level enemies will be before entering a location.*

Encounter zones are level scaling tools which Skyrim defines for each location in the game world. It uses these zones to **determine how strong enemies will be** in a particular area by giving each encounter zone a *minimum* and (optional) *maximum* level.

Enemies in Skyrim will try to scale with your level (*unless* you have a deleveling/releveling/whatever-leveling mod), but a location's encounter zone decides when this scaling *starts* and *stops*.

In vanilla Skyrim, the encounter zone for Embershard Mine has a *minimum* level of 6 and a *maximum* level of 10.
- **Before** you reach level 6, all enemies in this area will be at least level 6. Meaning your puny but well-meaning level 1 Dragonborn may have a little trouble with the bandits here.
- **Between** levels 6 and 10, the enemies in Embershard Mine will scale with you, giving your sweet growing Dragonborn a mostly balanced combat experience.
- **After** hitting level 10, however, the enemies' levels will cap out and no longer scale with you, meaning that your ripped dragon-slaying level 60 Dragonborn will be able to one-shot every stinky bandit in the place.


### So what? I love one-shotting bandits!
This isn't such a big deal with low-level dungeons like Embershard, but take another location, Forelhost, for example. In vanilla, this location's encounter zone has a minimum level of **24** and no maximum, meaning enemies will scale with you forever past level 24.

Let's say you, sweet Dragonborn, are level 5. You finished all the Riverwood claw business and you're really excited to join the Thieves' Guild so you head towards Riften, but you decide to do a couple dungeons in the area first. You happen to stumble upon Forelhost, yet another Nordic ruin with no indication that it'll be anything more difficult than the billion Draugr in Bleak Falls Barrow. But when you enter you find that *these* Draugr just keep kicking your a\*s for no reason, which is ** REALLY F\*\*\*ING FRUSTRATING AAAAAA HOW WERE YOU SUPPOSED TO KNOW THIS WOULD HAPPEN??!**

Wouldn't it be nice to at least get a *warning* or something?


### This Patcher

That's where this patcher comes in! You will now see the level ranges of enemies **before** you go in to get your a\*s kicked!

This patcher adds the level ranges for each location to map markers and/or the text that shows up when you enter a location.

- Embershard Mine becomes **Embershard Mine (Levels 6 to 10)**
- Forelhost becomes **Forelhost (Level 24+)**

Now you can look on the map to plan out your route based on what areas are actually going to be scaled to your level, or you can decide to back out just before you enter a one-shot death hellscape.

## Recommended Mods
This patch is complemented by [Encounter Zone Informer](https://www.nexusmods.com/skyrimspecialedition/mods/124456 "Encounter Zone Informer"), which warns you via notifications when you are entering an area scaled to a higher level than you.

This also pairs well with mods that add more variety and purpose to encounter zones, such as [OWL](https://www.nexusmods.com/skyrimspecialedition/mods/49681 "OWL")  or [MorrowLoot](https://www.nexusmods.com/skyrimspecialedition/mods/3058?tab=description "MorrowLoot").

## Acknowledgments
This patcher is basically an updated Synthesis version of [Cell Encounter Levels in Name](https://www.nexusmods.com/skyrimspecialedition/mods/4024 "Cell Encounter Levels in Name") and its successor [UPF Patcher - See the Encounter Zone level in the name of the zone](https://www.nexusmods.com/skyrimspecialedition/mods/19881/ "UPF Patcher - See the Encounter Zone level in the name of the zone"), so thank you to hishutup and mickthompson4000 for the initial idea and the guidance I got from their code.
