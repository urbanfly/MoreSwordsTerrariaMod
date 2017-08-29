using Terraria.ModLoader;

namespace More_Swords_Mod
{
	class More_Swords_Mod : Mod
	{
		public More_Swords_Mod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
