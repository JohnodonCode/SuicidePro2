using PluginAPI.Core;
using PluginAPI.Core.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using SuicidePro2.API.Features;

namespace SuicidePro2.Handlers.CustomEffectHandlers.Effects
{
    public class Explode : API.CustomEffect
    {
        public override string Id { get; } = "explode";

        [Description(
            "It is recommended not to change this. Radius of grenade explosion calculation (door damage, player damage). If this is -1, the value will not be modified, therefore, this will act as a normal grenade.")]
        public int Radius { get; set; } = 0;

        [Description(
            "Fuse time of the grenade. I don't know what the minimum is before the grenade acts all wacky, but 0.3 is a safe value.")]
        public float Fuse { get; set; } = 0.3f;

        public override bool Use(Player player, ArraySegment<string> args)
        {
            var grenade = Grenades.CreateThrowable(ItemType.GrenadeHE, player);

            grenade.SpawnActive(player.Position, Radius, Fuse, player);
            return true;
        }
    }
}
