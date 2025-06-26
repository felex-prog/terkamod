using Terraria;
using Terraria.ModLoader;

namespace TurtleMod.Players
{
    public class InfiniteAmmoPlayer : ModPlayer
    {
        public bool hasInfiniteAmmo;

        public override void ResetEffects()
        {
            hasInfiniteAmmo = false;
        }
        public override bool CanConsumeAmmo(Item weapon, Item ammo)
        {
            if (hasInfiniteAmmo)
            {
                return false;
            }
           return base.CanConsumeAmmo(weapon, ammo);
        }
    }
}
