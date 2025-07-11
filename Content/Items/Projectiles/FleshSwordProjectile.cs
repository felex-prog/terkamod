﻿using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;


namespace TurtleMod.Content.Projectiles
{
	public override string Texture => "TurtleMod/Content/Items/Projectiles/FleshSwordProjectile";
    public class FleshSwordProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 22;
            Projectile.height = 22;
            Projectile.friendly = false;

            Projectile.penetrate = -1;
            Projectile.timeLeft = 60;
            Projectile.tileCollide = false;
			Projectile.ownerHitCheck = true;
			Projectile.hide = true;
            
            
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
			Projectile.Center = player.Center + new Vector2(15 * player.direction,0);
        }

        

    }
}


