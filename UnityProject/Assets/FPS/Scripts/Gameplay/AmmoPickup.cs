using Unity.FPS.Game;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class AmmoPickup : Pickup
    {
        [Tooltip("Weapon those bullets are for")]
        [SerializeField] private WeaponController ammoWeapon;

        [Tooltip("Number of ammo the player gets")]
        [SerializeField] private int ammoCount = 30;

        protected override void OnPicked(PlayerCharacterController player)
        {
            var playerWeaponsManager = player.GetComponent<PlayerWeaponsManager>();
            if (playerWeaponsManager)
            {
                var weapon = playerWeaponsManager.HasWeapon(ammoWeapon);
                if (weapon != null)
                {
                    weapon.AddCarriablePhysicalBullets(ammoCount);

                    var evt = Events.AmmoPickupEvent;
                    evt.Weapon = weapon;
                    EventManager.Broadcast(evt);

                    PlayPickupFeedback();
                    Destroy(gameObject);
                }
            }
        }
    }
}
