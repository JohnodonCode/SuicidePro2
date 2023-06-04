using PlayerStatsSystem;
using PluginAPI.Core;
using SuicidePro2.API.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using Footprinting;
using UnityEngine;
using static PlayerStatsSystem.DamageHandlerBase;

namespace SuicidePro2.API.Extensions
{
    public static class PlayerExtensions
    {

        public static void Hurt(this Player player, PlayerStatsSystem.DamageHandlerBase damageHandlerBase)
        {
            player.ReferenceHub.playerStats.DealDamage(damageHandlerBase);
        }

        public static void Hurt(this Player player, float amount, DamageType damageType = DamageType.Unknown, string cassieAnnouncement = "")
        {
            Hurt(player, new CustomReasonDamageHandler(DamageTypeExtensions.TranslationConversion.FirstOrDefault((KeyValuePair<DeathTranslation, DamageType> k) => k.Value == damageType).Key.LogLabel, amount, cassieAnnouncement));
        }
    }
}
