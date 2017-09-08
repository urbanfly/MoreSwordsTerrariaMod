using Terraria.ID;
using Terraria.ModLoader;

namespace More_Swords_Mod.Items
{
    public class SplinterTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Splinter Tome");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.melee = false;
            item.width = 40;
            item.height = 40;
            item.useTime = 15;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.mana = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("SplinterBoltProjectile");
            item.shootSpeed = 12f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Paper", 5);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}



