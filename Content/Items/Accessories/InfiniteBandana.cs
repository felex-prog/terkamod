using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TurtleMod.Players;



namespace TurtleMod.Content.Items.Accessories
{
    public class InfiniteBandana : ModItem
    {
        private static int HeadSlot;
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 28;

            Item.rare = ItemRarityID.LightRed;
            Item.accessory = true;
            Item.vanity = true;
            
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Ranged) += 0.15f;

            player.GetModPlayer<InfiniteAmmoPlayer>().hasInfiniteAmmo = true;

            if (!hideVisual)
            {
                player.head = HeadSlot; 
            }
        }

        public override void Load()
        {
            HeadSlot = EquipLoader.AddEquipTexture(Mod, "TurtleMod/Content/Items/Accessories/InfiniteBandana_Head", EquipType.Head, name:"InfiniteBandana_Head");
        }

        public override void SetStaticDefaults()
        {
            ArmorIDs.Head.Sets.DrawHead[HeadSlot] = false;
            ArmorIDs.Head.Sets.DrawFullHair[HeadSlot] = true;
            ArmorIDs.Head.Sets.DrawHatHair[HeadSlot] = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

                recipe.AddIngredient(ItemID.EndlessQuiver);
                recipe.AddIngredient(ItemID.EndlessMusketPouch);
                recipe.AddIngredient(ItemID.Silk,5);

                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.Register();
        }
    }
}
