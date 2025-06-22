using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TurtleMod.Content.Items
{
    public class UltraGun : ModItem 
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.damage = 75;
            Item.knockBack = 2f;
            Item.crit = 10;

            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.autoReuse = false;
            Item.noMelee = true;
            Item.DamageType = DamageClass.Ranged;

            Item.shoot = ProjectileID.Bullet;
            Item.UseSound = SoundID.Item11;
            Item.value = Item.buyPrice(silver: 25);
            Item.rare = ItemRarityID.Blue;

            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 12f;
            
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            if (WorldGen.SavedOreTiers.Gold == TileID.Gold)
                recipe.AddIngredient(ItemID.GoldBar, 15);
            else
                recipe.AddIngredient(ItemID.PlatinumBar, 15);

            if (WorldGen.crimson)
                recipe.AddIngredient(ItemID.TheUndertaker);
            else
                recipe.AddIngredient(ItemID.Musket);

            recipe.AddIngredient(ItemID.Glass, 3);

            recipe.AddTile(TileID.Anvils);

            recipe.Register();

  
        }
    }
}
