using Persona_3_Reload_Intro_Movies.Template.Configuration;
using Reloaded.Mod.Interfaces.Structs;
using System.ComponentModel;

namespace Persona_3_Reload_Intro_Movies.Configuration
{
    public class Config : Configurable<Config>
    {
        [DisplayName("Original P3P Movie")]
        [Description("View this movie on startup?")]
        [DefaultValue(false)]
        public bool P3p { get; set; } = true;

        [DisplayName("Moonlight Daydream by the P3P Kotone Cutscenes Team")]
        [Description("View this movie on startup?")]
        [DefaultValue(true)]
        public bool P3pk { get; set; } = true;

        [DisplayName("P3R Movie (Soul Phrase by Mosq)")]
        [Description("View this movie on startup?")]
        [DefaultValue(false)]
        public bool SoulMosq { get; set; } = true;
    }

    /// <summary>
    /// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
    /// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
    /// </summary>
    public class ConfiguratorMixin : ConfiguratorMixinBase
    {
        // 
    }
}