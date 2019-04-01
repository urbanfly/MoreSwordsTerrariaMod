﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace More_Swords_Mod.Items
{
    public class AmberStaffProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "AmberStaffProjectile";
            projectile.width = 40;
            projectile.height = 40;
            projectile.friendly = true;
            projectile.penetrate = -1;                       //this is the projectile penetration
            //Main.projFrames[projectile.type] = 4;           //this is projectile frames
            projectile.hostile = false;
            projectile.magic = true;                        //this make the projectile do magic damage
            projectile.tileCollide = false;                 //this make that the projectile does not go thru walls
            projectile.ignoreWater = false;
        }

        public override void AI()
        {
            //this is projectile dust
           // int DustID2 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width + 2, projectile.height + 2, mod.DustType("DustName"), projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 20, default(Color), 2.9f);
           // Main.dust[DustID2].noGravity = true;
            //this make that the projectile faces the right way
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f;
            projectile.alpha = (int)projectile.localAI[0] * 2;

            if (projectile.localAI[0] > 130f) //projectile time left before disappears
            {
                projectile.Kill();
            }
        }

        //public override bool PreDraw(SpriteBatch sb, Color lightColor) //this is where the animation happens
        //{
        //    projectile.frameCounter++; //increase the frameCounter by one
        //    if (projectile.frameCounter >= 10) //once the frameCounter has reached 10 - change the 10 to change how fast the projectile animates
        //    {
        //        projectile.frame++; //go to the next frame
        //        projectile.frameCounter = 0; //reset the counter
        //        if (projectile.frame > 3) //if past the last frame
        //            projectile.frame = 0; //go back to the first frame
        //    }
        //    return true;
        //}
    }
}

