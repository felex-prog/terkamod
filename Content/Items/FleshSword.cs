using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TurtleMod.Content.Projectiles;


namespace TurtleMod.Content.Items
{
    public class FleshSword : ModItem 
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.scale = 1.2f;

            Item.damage = 250;
            Item.knockBack = 25;
            Item.crit = 25;
            Item.DamageType = DamageClass.Melee;

            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Rapier;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.autoReuse = false;

            Item.rare = ItemRarityID.Orange;
            Item.UseSound = SoundID.Item1;
            Item.shoot = ModContent.ProjectileType<FleshSwordProjectile>();
            Item.shootSpeed = 2.5f;

            Item.GetGlobalItem<BleedingFleshSword>().bleedChance = 0.5f;




        }
        public class BleedingFleshSword : GlobalItem
        {
            public float bleedChance = 0f;

            public override void OnHitNPC(Item item, Player player, NPC target, NPC.HitInfo hit, int damageDone)
            {

                if (item.type == ModContent.ItemType<FleshSword>() && Main.rand.NextFloat() < bleedChance)
                {
                    target.AddBuff(BuffID.Bleeding, 25);
                }
            }
            

        
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            if (WorldGen.crimson)
                recipe.AddIngredient(ItemID.CrimtaneBar, 10);
            else 
                recipe.AddIngredient(ItemID.DemoniteBar, 10);

            if (WorldGen.crimson)
                recipe.AddIngredient(ItemID.Vertebrae, 5);
            else
                recipe.AddIngredient(ItemID.ShadowScale, 5);

                recipe.AddTile(TileID.Anvils);
                recipe.Register();
        }

       
    } 
    
} 