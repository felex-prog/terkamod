using Terraria;
using Terraria.ModLoader;
using TurtleMod.Content.Projectiles;
using Terraria.DataStructures;
using TurtleMod.Content.Items;
using Microsoft.Xna.Framework;


namespace TurtleMod.Players
{
    public class BloodShadowPlayer : ModPlayer
    {
        public bool shadowActivate { get; set; }
        public int AbilityTimer { get; set; }
        public int CooldownTimer { get; set; }

        public const int MaxCooldown = 3600;
        public const int MaxAbilityDuration = 1200;

        public void ActivateAbility()
        {
            shadowActivate = true;
            AbilityTimer = MaxAbilityDuration;
            CooldownTimer = MaxCooldown;

            if (Player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(Player.GetSource_FromThis(), Player.Center, Vector2.Zero, ModContent.ProjectileType<BloodShadow>(), 0, 0, Player.whoAmI);
            }
        }
        public override void ResetEffects()
        {
           
            {
                Player.immune = true;
                Player.immuneTime = 2;
                Player.invis = false;

                if (--AbilityTimer <= 0)
                 shadowActivate = false;

                if (CooldownTimer > 0)
                    CooldownTimer--;
            }
          

            
        }
        public override void ModifyHitNPCWithItem(Item item, NPC target, ref NPC.HitModifiers modifiers)
        {
            if (shadowActivate && item.type == ModContent.ItemType<FleshSword>())
            {
                modifiers.SetCrit();
                modifiers.CritDamage += 2f;
            }
        }
    }
}
