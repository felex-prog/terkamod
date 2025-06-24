using Terraria.ModLoader;    

namespace TurtleMod.Systems
{
    public class KeyBindSystem : ModSystem
    {
        public static ModKeybind BloodShadowAbility { get; private set; }

        public override void Load()
        {
            BloodShadowAbility = KeybindLoader.RegisterKeybind(Mod, "Activation Blood Shadow", "G");
        }

        public override void Unload()
        {
            BloodShadowAbility = null;
        }
    }
}
