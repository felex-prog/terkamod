using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TurtleMod.Content.Projectiles
{
    public class BloodShadow : ModProjectile
    {
		public override string Texture => "TurtleMod/Content/Items/Projectiles/BloodShadow";
        public override void SetDefaults()
        {
            Projectile.width = 80;
            Projectile.height = 80;
            Projectile.timeLeft = 1200;

            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.penetrate = -1;
            Projectile.aiStyle = -1;
        }
        public override void AI()
        {
            foreach (NPC npc in Main.npc)
            {
                if (npc.active && !npc.friendly && npc.Distance(Projectile.Center) < 500f)
                {
                    npc.velocity = (Projectile.Center - npc.Center) * 0.05f;
                    npc.target = 255;
                }
            }
            if (Main.rand.NextBool(5))
            {
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.Blood);
            }
        }
    }
}
