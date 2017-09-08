using Terraria;
using Terraria.ModLoader;

namespace More_Swords_Mod.Items
{
    public class WyvernPetBuff : ModBuff
    {
        public override void SetDefaults()
        {
            //Main.buffName[Type] = "Cool Pet";
            //Main.buffTip[Type] = "It's cute!";
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<MyPlayer>(mod).Pet = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("PetName")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("PetName"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}
