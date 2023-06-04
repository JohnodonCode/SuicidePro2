using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using PluginAPI.Events;
using MEC;
using System.Collections.Generic;
using UnityEngine;

namespace SuicidePro2
{
    public class SuicidePro2
    {
        private const string Author = "Johnodon";

        private const string Name = "SuicidePro2";

        private const string Description = "Kill yourself in style!";

        private const string Version = "1.0.0";

        public EventHandlers EventHandlers;

        public const string LiteDBAssemblyName = "LiteDB";

        public List<CoroutineHandle> Coroutines = new List<CoroutineHandle>();
        //private Handler _cgEventHandlers;

        public static SuicidePro2 Instance { get; private set; }

        [PluginConfig()] public Config Config = new Config();

        [PluginPriority(LoadPriority.Lowest)]
        [PluginEntryPoint(Name, Version, Description, Author)]
        public void OnEnabled()
        {
            Instance = this;
            Log.Info($"Loaded {Name}");
            EventManager.RegisterEvents<EventHandlers>(this);
            PluginHandler handler = PluginHandler.Get(this);
            handler.SaveConfig(this, nameof(Config));
        }

        [PluginUnload]
        public void OnDisabled()
        {
            EventManager.UnregisterEvents(this, EventHandlers);
            Log.Info($"Unoaded {Name}");
        }
    }

    public class Velocity
    {
        public float ForwardVelocity { get; set; }
        public float UpwardsVelocity { get; set; }
        public float RightVelocity { get; set; }

        public Velocity()
        {
            ForwardVelocity = 1;
            UpwardsVelocity = 1;
            RightVelocity = 1;
        }

        public Velocity(float fwd, float upw, float rgt)// Just for creating an instance to look better.
        {
            ForwardVelocity = fwd;
            UpwardsVelocity = upw;
            RightVelocity = rgt;
        }

        public Vector3 ToVector3(Transform transform)
            => transform.forward * ForwardVelocity + transform.up * UpwardsVelocity + transform.right * RightVelocity;
    }
}
