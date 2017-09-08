using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace More_Swords_Mod.Items
{
    public class WyvernPetCall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sky Snake");
            Tooltip.SetDefault("Summons a Cool Pet to follow you");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = mod.ProjectileType("WyvernPet");
            item.buffType = mod.BuffType("WyvernPetBuff");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            //recipe.AddIngredient(ItemID.Feather, 10);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            // recipe.AddTile(null, "WBName");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}
