using System;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;

namespace HeadGuard
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Singleton = null;
        public override void Enable()
        {
            throw new NotImplementedException();
        }

        public override void Disable()
        {
            throw new NotImplementedException();
        }

        public override string Name { get; } = "Head Guard";
        public override string Description { get; } = "Plugin per ruolo custom head guard, in labapi";
        public override string Author { get; } = "Lenard";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredApiVersion { get; } = new Version(LabApiProperties.CompiledVersion);
    }

    public class Config
    {
        public int ChanceSpawn { get; set; } = 100;
        public int MinPlayer { get; set; } = 0;
        public int MaxSpawn { get; set; } = 1;
        public int maxhp { get; set; } = 90;

    }
}