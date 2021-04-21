using Unity.FPS.Game;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class HealthPickup : Pickup
    {
        [Header("Parameters")] 
        [Tooltip("Amount of health to heal on pickup")]
        [SerializeField] private float healAmount;

        protected override void OnPicked(PlayerCharacterController player)
        {
            var playerHealth = player.GetComponent<Health>();
            if(playerHealth && playerHealth.CanPickup())
            {
                playerHealth.Heal(healAmount);
                PlayPickupFeedback();
                Destroy(gameObject);
            }
        }
    }
}