using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandSystem;
using NWAPIPermissionSystem;
using RemoteAdmin;
using Log = PluginAPI.Core.Log;
using SuicidePro2;
using PluginAPI.Core;
using Config = SuicidePro2.Config;
using SuicidePro2.Handlers;

namespace SuicidePro2.Handlers
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class KillCommand : ICommand
    {
        //public string Command => SuicidePro2.Instance.Config.CommandPrefix;
        public string Command => "kill";
        //public string[] Aliases => SuicidePro2.Instance.Config.CommandAliases;
        public string[] Aliases => new string[] {"suicide", "die"};
        public string Description => "A kill command with more features.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {

            PlayerCommandSender playerCommandSender = sender as PlayerCommandSender;
            if (playerCommandSender == null)
            {
                response = "You must run this command as a client and not server.";
                return false;
            }

            string arg = arguments.FirstOrDefault();
            Player player = Player.Get(playerCommandSender);

            if (SuicidePro2.Instance.Config.HelpCommandAliases.Contains(arg))
            {
                var build = new StringBuilder("Here are all the kill commands you can use:\n\n");
                foreach (var commandConfig in SuicidePro2.Instance.Config.KillConfigs)
                {
                    if (commandConfig.Permission == "none" || player.CheckPermission(FormatPermission(commandConfig)))
                        build.Append($"<b><color=white>.kill</color> <color=yellow>{commandConfig.Name}</color></b> {(commandConfig.Aliases.Any() ? $"<color=#3C3C3C>({String.Join(", ", commandConfig.Aliases)})</color>" : String.Empty)}\n<color=white>{commandConfig.Description}</color>\n\n");
                }

                foreach (var effect in API.CustomEffect.Effects)
                {
                    if (effect.Config.Enabled && (effect.Config.Permission == "none" || player.CheckPermission(FormatPermission(effect.Config))))
                        build.Append($"<b><color=white>.kill</color> <color=yellow>{effect.Config.Name}</color></b> {(effect.Config.Aliases.Any() ? $"<color=#3C3C3C>({String.Join(", ", effect.Config.Aliases)})</color>" : String.Empty)}\n<color=white>{effect.Config.Description}</color>\n\n");
                }

                response = build.ToString();
                return true;
            }

            if (arg == null)
                arg = "default";

            IEnumerable<Config.BaseCommandConfig> configs = SuicidePro2.Instance.Config.KillConfigs.Concat((IEnumerable<Config.BaseCommandConfig>)SuicidePro2.Instance.Config.DamageTypeKillConfigs);
            Config.BaseCommandConfig config = configs.FirstOrDefault(x => x.Name == arg || x.Aliases.Contains(arg));
            var customConfig = API.CustomEffect.Effects.FirstOrDefault(x => x.Config.Name == arg || x.Config.Aliases.Contains(arg));

            if (config == null && customConfig == null)
            {
                response = $"Could not find any kill command with the name or alias {arg}.";
                return false;
            }

            if (customConfig != null)
                config = customConfig.Config;

            if (config.Permission != "none" && !player.CheckPermission(FormatPermission(config)))
            {
                response = "You do not have the required permissions for this command.";
                return false;
            }

            if (!Round.IsRoundStarted)
            {
                response = "The round has not started yet.";
                return false;
            }

            if (config.BannedRoles.Contains(player.Role) || !player.IsAlive)
            {
                response = "You cannot run this kill variation as your role.";
                return false;
            }

            if (customConfig == null)
            {
                config.Run(player);
            }
            else
            {
                var ans = customConfig.Run(player, arguments);
                if (!ans && !SuicidePro2.Instance.Config.AllowRunningDisabledForceRegistered)
                {
                    response = "This effect is disabled.";
                    return false;
                }
            }

            response = config.Response;
            return true;
        }

        public string FormatPermission(Config.BaseCommandConfig config)
        {
            if (config.Permission == "default")
            {
                Log.Debug("Permission name is 'default', returning kl." + config.Name, SuicidePro2.Instance.Config.Debug);
                return $"kl.{config.Name}";
            }
            Log.Debug("Permission name is not 'default', returning " + config.Permission, SuicidePro2.Instance.Config.Debug);
            return config.Permission;
        }
    }
}
