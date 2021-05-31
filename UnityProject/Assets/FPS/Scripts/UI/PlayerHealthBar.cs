using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.UI;

namespace Unity.FPS.UI
{
    public class PlayerHealthBar : MonoBehaviour
    {
        [Tooltip("Image component dispplaying current health")]
        public Image healthFillImage;

        [Tooltip("Player Health Object")]
        public Health playerHealth;

        void Update()
        {
            // Update health bar value
            healthFillImage.fillAmount = playerHealth.CurrentHealth / playerHealth.MaxHealth;
            healthFillImage.color = playerHealth.GetPlayer().player.color;
        }
    }
}