
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameInput;
using SORR.buffs.Debuffs;

namespace SORR
{
    public class SORRPlayer : ModPlayer
    {



        public bool ArgentBurns = false;
        public bool KiskaBuff;
        
        public override void ResetEffects()
        {
            ArgentBurns = false;
        }

        public override void UpdateBadLifeRegen()
        {
            if (ArgentBurns)  // make sure you add the right bool 
            {
                player.lifeRegen -= 75; //this make so the player take damage, the highter is the value the more life losing.
            }
        }

    }
}