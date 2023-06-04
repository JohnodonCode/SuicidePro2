using UnityEngine;
using InventorySystem.Items;
using PluginAPI.Core;
using InventorySystem.Items.ThrowableProjectiles;
using InventorySystem.Items.Pickups;
using Footprinting;
using Mirror;


namespace SuicidePro2.API.Features
{
    public static class Grenades
    {
        public static ThrowableItem CreateThrowable(ItemType type, Player player = null) => (player != null ? player.ReferenceHub : ReferenceHub.HostHub)
            .inventory.CreateItemInstance(new ItemIdentifier(type, ItemSerialGenerator.GenerateNext()), false) as ThrowableItem;
        public static void SpawnActive(this ThrowableItem item, Vector3 position, float maxRadius, float fuseTime = -1f,
            Player owner = null)
        {
            ExplosionGrenade grenade = (ExplosionGrenade)UnityEngine.Object.Instantiate(item.Projectile, position, Quaternion.identity);
            if (fuseTime >= 0)
                grenade._fuseTime = fuseTime;
            grenade._maxRadius = maxRadius;
            grenade.NetworkInfo = new PickupSyncInfo(item.ItemTypeId, position, Quaternion.identity, item.Weight, item.ItemSerial);
            grenade.PreviousOwner = new Footprint(owner != null ? owner.ReferenceHub : ReferenceHub.HostHub);
            if (grenade is Scp018Projectile scp018)
                scp018.RigidBody.velocity = new Vector3(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value); // add some force to make the ball bounce
            NetworkServer.Spawn(grenade.gameObject);
            grenade.ServerActivate();
        }
    }
}
