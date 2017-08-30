using Terraria.ID;
using Terraria.ModLoader;

namespace More_Swords_Mod.Items
{
    public class SpikeBolt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spike Bolt");
            Tooltip.SetDefault("Careful not to point this at yourself..");
        }

        public override void SetDefaults()
        {
            item.damage = 40;
            item.melee = false;
            item.width = 40;
            item.height = 40;
            item.useTime = 12;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.mana = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("SpikeBoltProjectile");
            item.shootSpeed = 8f ;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            //recipe.AddIngredient(ItemID.Spike, 5);
            recipe.AddIngredient(ItemID.FallenStar, 3);
           // recipe.AddIngredient(ItemID.Book, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}


