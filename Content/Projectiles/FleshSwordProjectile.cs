using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;


namespace TurtleMod.Content.Projectiles
{
    public class FleshSwordProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 22;
            Projectile.height = 22;
            Projectile.friendly = true;

            Projectile.penetrate = -1;
            Projectile.timeLeft = 10;
            Projectile.tileCollide = false;
            Projectile.ownerHitCheck = true;
            Projectile.hide = true;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            Projectile.Center = player.Center + new Vector2(15 * player.direction, 0);
            }

    }
}


