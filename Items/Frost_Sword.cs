using Terraria.ID;
using Terraria.ModLoader;

namespace More_Swords_Mod.Items
{
    public class Frost_Sword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Sword");
            Tooltip.SetDefault("It is cool to the touch.");
        }

        public override void SetDefaults()
        {
            item.damage = 40;
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
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddIngredient(ItemID.IceBlock, 10);
            recipe.AddIngredient(ItemID.Shiverthorn, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

