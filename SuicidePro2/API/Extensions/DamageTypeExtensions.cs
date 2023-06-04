using PlayerStatsSystem;
using PluginAPI.Core;
using SuicidePro2.API.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuicidePro2.API.Extensions
{
    //
    // Summary:
    //     A set of extensions for Exiled.API.Enums.DamageType.
    public static class DamageTypeExtensions
    {
        //
        // Summary:
        //     Gets conversion information between PlayerStatsSystem.DeathTranslation.Ids and
        //     Exiled.API.Enums.DamageTypes.
        public static Dictionary<byte, DamageType> TranslationIdConversion
        {
            get;
        } = new Dictionary<byte, DamageType>
        {
            {
                DeathTranslations.Asphyxiated.Id,
                DamageType.Asphyxiation
            },
            {
                DeathTranslations.Bleeding.Id,
                DamageType.Bleeding
            },
            {
                DeathTranslations.Crushed.Id,
                DamageType.Crushed
            },
            {
                DeathTranslations.Decontamination.Id,
                DamageType.Decontamination
            },
            {
                DeathTranslations.Explosion.Id,
                DamageType.Explosion
            },
            {
                DeathTranslations.Falldown.Id,
                DamageType.Falldown
            },
            {
                DeathTranslations.Poisoned.Id,
                DamageType.Poison
            },
            {
                DeathTranslations.Recontained.Id,
                DamageType.Recontainment
            },
            {
                DeathTranslations.Scp049.Id,
                DamageType.Scp049
            },
            {
                DeathTranslations.Scp096.Id,
                DamageType.Scp096
            },
            {
                DeathTranslations.Scp173.Id,
                DamageType.Scp173
            },
            {
                DeathTranslations.Scp207.Id,
                DamageType.Scp207
            },
            {
                DeathTranslations.Scp939Lunge.Id,
                DamageType.Scp939Lunge
            },
            {
                DeathTranslations.Scp939Other.Id,
                DamageType.Scp939Other
            },
            {
                DeathTranslations.Tesla.Id,
                DamageType.Tesla
            },
            {
                DeathTranslations.Unknown.Id,
                DamageType.Unknown
            },
            {
                DeathTranslations.Warhead.Id,
                DamageType.Warhead
            },
            {
                DeathTranslations.Zombie.Id,
                DamageType.Scp0492
            },
            {
                DeathTranslations.BulletWounds.Id,
                DamageType.Firearm
            },
            {
                DeathTranslations.PocketDecay.Id,
                DamageType.PocketDimension
            },
            {
                DeathTranslations.SeveredHands.Id,
                DamageType.SeveredHands
            },
            {
                DeathTranslations.FriendlyFireDetector.Id,
                DamageType.FriendlyFireDetector
            },
            {
                DeathTranslations.UsedAs106Bait.Id,
                DamageType.FemurBreaker
            },
            {
                DeathTranslations.MicroHID.Id,
                DamageType.MicroHid
            },
            {
                DeathTranslations.Hypothermia.Id,
                DamageType.Hypothermia
            }
        };


        //
        // Summary:
        //     Gets conversion information between PlayerStatsSystem.DeathTranslations and Exiled.API.Enums.DamageTypes.
        public static Dictionary<DeathTranslation, DamageType> TranslationConversion
        {
            get;
        } = new Dictionary<DeathTranslation, DamageType>
        {
            {
                DeathTranslations.Asphyxiated,
                DamageType.Asphyxiation
            },
            {
                DeathTranslations.Bleeding,
                DamageType.Bleeding
            },
            {
                DeathTranslations.Crushed,
                DamageType.Crushed
            },
            {
                DeathTranslations.Decontamination,
                DamageType.Decontamination
            },
            {
                DeathTranslations.Explosion,
                DamageType.Explosion
            },
            {
                DeathTranslations.Falldown,
                DamageType.Falldown
            },
            {
                DeathTranslations.Poisoned,
                DamageType.Poison
            },
            {
                DeathTranslations.Recontained,
                DamageType.Recontainment
            },
            {
                DeathTranslations.Scp049,
                DamageType.Scp049
            },
            {
                DeathTranslations.Scp096,
                DamageType.Scp096
            },
            {
                DeathTranslations.Scp173,
                DamageType.Scp173
            },
            {
                DeathTranslations.Scp207,
                DamageType.Scp207
            },
            {
                DeathTranslations.Scp939Lunge,
                DamageType.Scp939Lunge
            },
            {
                DeathTranslations.Scp939Other,
                DamageType.Scp939Other
            },
            {
                DeathTranslations.Tesla,
                DamageType.Tesla
            },
            {
                DeathTranslations.Unknown,
                DamageType.Unknown
            },
            {
                DeathTranslations.Warhead,
                DamageType.Warhead
            },
            {
                DeathTranslations.Zombie,
                DamageType.Scp0492
            },
            {
                DeathTranslations.BulletWounds,
                DamageType.Firearm
            },
            {
                DeathTranslations.PocketDecay,
                DamageType.PocketDimension
            },
            {
                DeathTranslations.SeveredHands,
                DamageType.SeveredHands
            },
            {
                DeathTranslations.FriendlyFireDetector,
                DamageType.FriendlyFireDetector
            },
            {
                DeathTranslations.UsedAs106Bait,
                DamageType.FemurBreaker
            },
            {
                DeathTranslations.MicroHID,
                DamageType.MicroHid
            },
            {
                DeathTranslations.Hypothermia,
                DamageType.Hypothermia
            }
        };


        //
        // Summary:
        //     Gets conversion information between ItemTypes and Exiled.API.Enums.DamageTypes.
        public static Dictionary<ItemType, DamageType> ItemConversion
        {
            get;
        } = new Dictionary<ItemType, DamageType>
        {
            {
                ItemType.GunCrossvec,
                DamageType.Crossvec
            },
            {
                ItemType.GunLogicer,
                DamageType.Logicer
            },
            {
                ItemType.GunRevolver,
                DamageType.Revolver
            },
            {
                ItemType.GunShotgun,
                DamageType.Shotgun
            },
            {
                ItemType.GunAK,
                DamageType.AK
            },
            {
                ItemType.GunCOM15,
                DamageType.Com15
            },
            {
                ItemType.GunCOM18,
                DamageType.Com18
            },
            {
                ItemType.GunFSP9,
                DamageType.Fsp9
            },
            {
                ItemType.GunE11SR,
                DamageType.E11Sr
            },
            {
                ItemType.MicroHID,
                DamageType.MicroHid
            },
            {
                ItemType.ParticleDisruptor,
                DamageType.ParticleDisruptor
            }
        };


        //
        // Summary:
        //     Check if a damage type is caused by weapon.
        //
        // Parameters:
        //   type:
        //     The damage type to be checked.
        //
        //   checkMicro:
        //     Indicates whether the MicroHid damage type should be taken into account or not.
        //
        // Returns:
        //     Returns whether the Exiled.API.Enums.DamageType is caused by weapon or not.
        public static bool IsWeapon(this DamageType type, bool checkMicro = true)
        {
            switch (type)
            {
                case DamageType.Crossvec:
                case DamageType.Logicer:
                case DamageType.Revolver:
                case DamageType.Shotgun:
                case DamageType.AK:
                case DamageType.Com15:
                case DamageType.Com18:
                case DamageType.Fsp9:
                case DamageType.E11Sr:
                case DamageType.ParticleDisruptor:
                    return true;
                case DamageType.MicroHid:
                    if (checkMicro)
                    {
                        return true;
                    }

                    break;
            }

            return false;
        }

        //
        // Summary:
        //     Check if a damage type is caused by SCP.
        //
        // Parameters:
        //   type:
        //     The damage type to be checked.
        //
        //   checkItems:
        //     Indicates whether the SCP-items damage types should be taken into account or
        //     not.
        //
        // Returns:
        //     Returns whether the Exiled.API.Enums.DamageType is caused by SCP or not.
        public static bool IsScp(this DamageType type, bool checkItems = true)
        {
            switch (type)
            {
                case DamageType.Scp:
                case DamageType.Scp049:
                case DamageType.Scp096:
                case DamageType.Scp173:
                case DamageType.Scp939Lunge:
                case DamageType.Scp939Other:
                case DamageType.Scp0492:
                case DamageType.Scp106:
                    return true;
                case DamageType.Scp018:
                case DamageType.Scp207:
                    if (checkItems)
                    {
                        return true;
                    }

                    break;
            }

            return false;
        }

        //
        // Summary:
        //     Check if a damage type is caused by status effect.
        //
        // Parameters:
        //   type:
        //     The damage type to be checked.
        //
        // Returns:
        //     Returns whether the Exiled.API.Enums.DamageType is caused by status effect or
        //     not.
        public static bool IsStatusEffect(this DamageType type)
        {
            if ((uint)(type - 4) <= 2u || type == DamageType.Scp207 || type == DamageType.Hypothermia)
            {
                return true;
            }

            return false;
        }

        //
        // Summary:
        //     Gets the Exiled.API.Enums.DamageType of an PlayerStatsSystem.DamageHandlerBases.
        //
        // Parameters:
        //   damageHandlerBase:
        //     The DamageHandler you want to get the DamageType.
        //
        // Returns:
        //     Return the Exiled.API.Enums.DamageType of the PlayerStatsSystem.DamageHandlerBase.
        public static DamageType GetDamageType(DamageHandlerBase damageHandlerBase)
        {
            if (!(damageHandlerBase is CustomReasonDamageHandler))
            {
                if (!(damageHandlerBase is WarheadDamageHandler))
                {
                    if (!(damageHandlerBase is ExplosionDamageHandler))
                    {
                        if (!(damageHandlerBase is Scp018DamageHandler))
                        {
                            if (!(damageHandlerBase is RecontainmentDamageHandler))
                            {
                                if (!(damageHandlerBase is Scp096DamageHandler))
                                {
                                    if (!(damageHandlerBase is MicroHidDamageHandler))
                                    {
                                        FirearmDamageHandler firearmDamageHandler = damageHandlerBase as FirearmDamageHandler;
                                        if (firearmDamageHandler == null)
                                        {
                                            ScpDamageHandler scpDamageHandler = damageHandlerBase as ScpDamageHandler;
                                            if (scpDamageHandler == null)
                                            {
                                                UniversalDamageHandler universalDamageHandler = damageHandlerBase as UniversalDamageHandler;
                                                if (universalDamageHandler != null)
                                                {
                                                    DeathTranslation deathTranslation = DeathTranslations.TranslationsById[universalDamageHandler.TranslationId];
                                                    if (TranslationIdConversion.ContainsKey(deathTranslation.Id))
                                                    {
                                                        return TranslationIdConversion[deathTranslation.Id];
                                                    }

                                                    Log.Warning(string.Format("{0}.{1}: No matching {2} for {3} with ID {4}, type will be reported as {5}. Report this to EXILED Devs.", "DamageTypeExtensions", "damageHandlerBase", "DamageType", "UniversalDamageHandler", deathTranslation.Id, DamageType.Unknown));
                                                    return DamageType.Unknown;
                                                }

                                                return DamageType.Unknown;
                                            }

                                            DeathTranslation deathTranslation2 = DeathTranslations.TranslationsById[scpDamageHandler._translationId];
                                            if (deathTranslation2.Id == DeathTranslations.PocketDecay.Id)
                                            {
                                                return DamageType.Scp106;
                                            }

                                            if (!TranslationIdConversion.ContainsKey(deathTranslation2.Id))
                                            {
                                                return DamageType.Scp;
                                            }

                                            return TranslationIdConversion[deathTranslation2.Id];
                                        }

                                        if (!ItemConversion.ContainsKey(firearmDamageHandler.WeaponType))
                                        {
                                            return DamageType.Firearm;
                                        }

                                        return ItemConversion[firearmDamageHandler.WeaponType];
                                    }

                                    return DamageType.MicroHid;
                                }

                                return DamageType.Scp096;
                            }

                            return DamageType.Recontainment;
                        }

                        return DamageType.Scp018;
                    }

                    return DamageType.Explosion;
                }

                return DamageType.Warhead;
            }

            return DamageType.Custom;
        }
    }
}
