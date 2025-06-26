using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;


namespace TurtleMod.Content.Projectiles
{
    public class FleshSwordProjectile : ModProjectile
    {
        public override string Texture => "TurtleMod/Content/Items/Projectiles/FleshSwordProjectile";

        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 6;
            ProjectileID.Sets.TrailCacheLength[Projectile.type] = 4;
        }
        public override void SetDefaults()
        {
            Projectile.width = 22;
            Projectile.height = 22;
            Projectile.friendly = true;

            Projectile.penetrate = -1;
            Projectile.timeLeft = 60;
            Projectile.tileCollide = false;
            
            
        }

        public override void AI()
        {
            if (++Projectile.frameCounter >= 5)
            {
                Projectile.frameCounter = 0;
                if (Projectile.frameCounter >= 6)
                    Projectile.frame = 0;
            }

            if (Main.rand.NextBool(3))
            {
                Dust.NewDustPerfect(Projectile.Center, DustID.Blood, Vector2.Zero, 100, default, 1.5f);
            }
        }

        public override bool PreDraw(ref Color lightColor)
        {
            Texture2D tex = ModContent.Request<Texture2D>(Texture).Value;
            Rectangle frame = new Rectangle(0, Projectile.frame * Projectile.height, Projectile.width, Projectile.height);
            Main.EntitySpriteDraw(tex, Projectile.Center - Main.screenPosition, frame, Color.Red * 0.8f, Projectile.rotation, new Vector2(Projectile.width / 2, Projectile.height / 2), Projectile.scale, SpriteEffects.None, 0);
            
            return false;

        }

    }
}


