using Terraria;
using Terraria.ModLoader;
using Terraria.GameInput;
using Microsoft.Xna.Framework;
using TurtleMod.Systems;
using TurtleMod.Content.Projectiles;


namespace TurtleMod.Players
{
    public class BloodShadowAbilityPLayer : ModPlayer
    {
        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            var KeyBindSystem= ModContent.GetInstance<KeyBindSystem>();
            if (KeyBindSystem.BloodShadowAbility.JustPressed)
            {
                var shadowPlayer = Player.GetModPlayer<BloodShadowPlayer>();
                if (!shadowPlayer.shadowActivate && shadowPlayer.CooldownTimer <= 0)
                {
                    shadowPlayer.shadowActivate = true;
                    shadowPlayer.AbilityTimer = 1200;
                    shadowPlayer.CooldownTimer = 3600;

                    Projectile.NewProjectile(Player.GetSource_FromThis(), Player.Center, Vector2.Zero, ModContent.ProjectileType<BloodShadow>(), 0, 0, Player.whoAmI);
                }
            }
        }
    }
    
}
