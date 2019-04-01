/*using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace More_Swords_Mod.Items
{
    public class Corruptraumatize : ModNPC
    {
        public override void SetDefaults()
        {
            //npc.Name = "Corruptraumatize";
            //npc.DisplayName = "Corruptraumatize";
            npc.aiStyle = 5;
            npc.lifeMax = 4500;
            npc.damage = 50;
            npc.defense = 20;
            npc.knockBackResist = 0f;
            npc.width= 100;
            npc.height =100;
           // animationType = NPCID.DemonEye;
            //Main.npcFrameCount[npc.type] = 4;
            npc.value = Item.buyPrice(0, 40, 75, 45);
            npc.npcSlots = 1f;
            npc.boss = true;
            npc.lavaImmune = false;
            npc.noGravity = true;
            npc.noTileCollide = false;
            //npc.soundHit = 8;
            //npc.soundKilled = 14;
            npc.buffImmune[24] = true;
            music = MusicID.Boss2;
            npc.netAlways = true;
        }

        //public override void AutoloadHead(ref string headTexture, ref string bossHeadTexture)
        //{
        //    bossHeadTexture = "Corruptraumatize"; //the boss head texture
        //}

        public override string BossHeadTexture
        {
            get
            {
                return "Corruptraumatize"; //the boss head texture
            }
        }

        public override void BossLoot(ref string name, ref int potionType)
        {
            //PotionType = ItemID.LesserHealingPotion;  //boss drops
            //Item.NewItem((int)npc.position.X. (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FrostSword"));
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale);  //boss life scale in expert mode
          //  npc.damage - (int)(npc.damage * 0.6f *); // boss damage in expert mode
        }
    }
}*/


