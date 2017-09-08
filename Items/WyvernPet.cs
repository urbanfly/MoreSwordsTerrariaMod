using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace More_Swords_Mod.Items
{
    public class MyPlayer : ModPlayer
    {
        public MyPlayer()
        {
            Pet = true;
        }

        public bool Pet { get; set; }
    }

    public class WyvernPet : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            projectile.Name = "WyvernPet";
            aiType = ProjectileID.ZephyrFish;
            //Main.projFrames[projectile.type] = 4;
            //Main.projPet[projectile.type] = true;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.zephyrfish = false;
            return true;
        }

        public override void AI()
        {
            var player = Main.player[projectile.owner];
            var modPlayer = player.GetModPlayer<MyPlayer>(mod);
            if (player.dead)
            {
                modPlayer.Pet = false;
            }
            if (modPlayer.Pet)
            {
                projectile.timeLeft = 2;
            }
        }
    }
}
