using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaPlus.items
{
	public class RustyPickaxe : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Rusty Pickaxe"; // The item display name in-game.
			item.damage = 5; // The amount of damage the item deals.
			item.melee = true; // Confirms that the item is indeed a melee item.
			item.width = 16; // The width of the item in-game.
			item.height = 16; // The height of the item in-game.
			item.toolTip = "A Rusty Old Pickaxe!"; // The displayed tool-tip in-game/
			item.useTime = 10; // The amount of time it takes the item to be used.
			item.useAnimation = 10; // The amount of time the animation is displayed.
			item.pick = 220; // The pickaxe power of the item.
			item.useStyle = 1; // The use style of the item.
			item.knockBack = 6; // The knockback of the item.
			item.value = (0, 0, 15, 0); // The items value in PPGGSSCC.
			item.rare = 0 // The font color and rarity of the item.
			item.UseSound = SoundID.Item1; // The sound the items make when used
			item.autoReuse = true; // "Auto swing"
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod); // Required.
			recipe.AddIngredient(ItemID.AnyCopperPickaxe, 1 ); // The rquired ingredients.
      			recipe.AddIngredient(ItemID.Cobweb, 10 ); // The rquired ingredients.
			recipe.AddTile(ItemID.Workbench); // The rquired crafting station.
			recipe.SetResult(this); // The result of crafting.
			recipe.AddRecipe(); // Required.
		}
	}
}