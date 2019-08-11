using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace EoCMusicChange
{
	public class EoCMusicChange : Mod
	{
		public EoCMusicChange()
		{
		}
		
		public override void UpdateMusic(ref int music,ref MusicPriority priority)
        {
			if(NPC.AnyNPCs(NPCID.EyeofCthulhu))
            {
				music = MusicID.Boss5;
                priority = MusicPriority.BossMedium;
            }       
		}
	}
}