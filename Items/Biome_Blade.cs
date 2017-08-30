using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace More_Swords_Mod.Items
{
    public class Biome_Blade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Biome blade");
            Tooltip.SetDefault("It is infused with the power of all biomes.");
        }

        public override void SetDefaults()
        {
            item.damage = 100;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 12;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Desert_Scourge", 1);
            recipe.AddIngredient(ItemID.LightsBane, 1);
            recipe.AddIngredient(ItemID.BladeofGrass, 1);
            recipe.AddIngredient(null, "FrostSword", 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
