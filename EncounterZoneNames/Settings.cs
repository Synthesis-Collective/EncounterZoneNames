using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Add this namespace
using Mutagen.Bethesda.Plugins;
using System.ComponentModel;
using Mutagen.Bethesda.Strings;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using Synthesis.Bethesda.Commands;

namespace EncounterZoneNames
{
    public record Settings
    {
        [SettingName("Patch Cell Names")]
        [Tooltip("This decides whether cell names will be modified. These are the names that show up on your HUD " +
                 "as you enter a location.")]
        [MaintainOrder]
        public bool PatchCellNames { get; set; } = true;
        
        [SettingName("Patch Map Markers")]
        [Tooltip("This decides whether map marker names will be modified")]
        [MaintainOrder]
        public bool PatchMapMarkers { get; set; } = true;
        
        [SettingName("Singular Prefix")]
        [Tooltip("This decides what appears between the location name and the encounter zone's minimum level when " +
                 "a location has only a minimum level (no maximum)\n" +
                 "With the default value 'Level', you would see: 'Chillwind Depths (Level 5)\n" +
                 "If you want no prefix, like: 'Chillwind Depths (5)', make this blank.")]
        [MaintainOrder]
        public string LevelPrefixSingular { get; set; } = "Level";

        [SettingName("Plural Prefix")]
        [Tooltip("This decides what appears between the location name and the encounter zone's min/max levels when" +
                 " a location has both a minimum AND a maximum level.\n" +
                 "With the default value 'Levels', you would see: 'Stinky Cave (Levels 20 - 50)'\n" +
                 "If you want no prefix, like: 'Stinky Cave (20 - 50)' make this blank.")]
        [MaintainOrder]
        public string LevelPrefixPlural { get; set; } = "Levels";
        
        [SettingName("Use Plus (+)")]
        [Tooltip("This decides whether encounter zones with only a minimum level (no maximum) will be displayed" +
                 "with plus sign (e.g. Chillwind Depths (Level 5+)")]
        [MaintainOrder]
        public bool UsePlus { get; set; } = true;
        
        [SettingName("Use Hyphen (-)")]
        [Tooltip("This decides whether encounter zones with a minimum and maximum level will be displayed with a " +
                 "hyphen or the letters 'to' when displaying the level range. This option is provided because some UI " +
                 "fonts (like those in Edge UI) don't render the hyphen correctly.\n" +
                 "If true, you will see 'Stinky Cave (Levels 20 - 50)'\n" +
                 "If false, you will see 'Stinky Cave (Levels 20 to 50)'")]
        [MaintainOrder]
        public bool UseHyphen { get; set; } = true;
        
        [SettingName("Verbose Log")]
        [Tooltip("This decides whether or not skipped cells will be shown in the log (there will always be a lot " +
                 "of skipped cells because there's a lot of cells with no encounter zones or other normal reasons " +
                 "why they would be skipped)")]
        [MaintainOrder]
        public bool Verbose { get; set; } = false;
        

        [SettingName("Language")]
        [MaintainOrder]
        [Ignore]
        public Language TargetLanguage { get; set; } = Language.English;
    }
}
