using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TurtleMod.Content.Items;

      
namespace TurtleMod.Content.GlobalItems
{
      public class BleedingFleshSword : GlobalItem
      {
            public float bleedChance = 0.2f;

        public override bool InstancePerEntity => true;

        public override void SetDefaults(Item item)
        {
            if (item.type == ModContent.ItemType<FleshSword>())
            {
                bleedChance = 0.35f;
            }
        }


            public override void OnHitNPC(Item item, Player player, NPC target, NPC.HitInfo hit, int damageDone)
            {

               if (item.type == ModContent.ItemType<FleshSword>() && Main.rand.NextFloat() < bleedChance)
               {
                    target.AddBuff(BuffID.Bleeding, 950);
                   for (int i = 0; i < 5; i++) 
                   {
                    Dust.NewDust(target.position, target.width, target.height, DustID.Blood, Scale: 1.5f);
                   }

                    
               }
            }
      }
}		