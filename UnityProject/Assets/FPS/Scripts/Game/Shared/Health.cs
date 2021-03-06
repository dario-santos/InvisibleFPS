using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Unity.FPS.Game
{
    public class Health : MonoBehaviour
    {
        [Tooltip("Maximum amount of health")] public float MaxHealth = 10f;

        [Tooltip("Health ratio at which the critical health vignette starts appearing")]
        public float CriticalHealthRatio = 0.3f;

        public UnityAction<float, GameObject> OnDamaged;
        public UnityAction<float> OnHealed;
        public UnityAction OnDie;
        public UnityAction OnRevive;
        [SerializeField] private bool isFriendlyFireActive = false;

        public float CurrentHealth { get; set; }
        public bool Invincible { get; set; }
        
        bool m_IsDead;


        private Vector3 initialPosition;

        private IEnumerator Revive(int seconds)
        {
            yield return new WaitForSeconds(seconds);
            
            OnRevive?.Invoke();

            transform.localPosition = initialPosition;

            CurrentHealth = MaxHealth;

            m_IsDead = false;
        }

        void Start()
        {
            initialPosition = transform.position;

            CurrentHealth = MaxHealth;
        }

        public bool CanPickup()
            => CurrentHealth < MaxHealth;

        public float GetRatio() 
            => CurrentHealth / MaxHealth;
        
        public bool IsCritical() 
            => GetRatio() <= CriticalHealthRatio;

        public void Heal(float healAmount)
        {
            float healthBefore = CurrentHealth;
            CurrentHealth += healAmount;
            CurrentHealth = Mathf.Clamp(CurrentHealth, 0f, MaxHealth);

            // call OnHeal action
            float trueHealAmount = CurrentHealth - healthBefore;
            if (trueHealAmount > 0f)
            {
                OnHealed?.Invoke(trueHealAmount);
            }
        }

        public void TakeDamage(float damage, GameObject damageSource)
        {
            if (Invincible)
                return;

            if (isFriendlyFireActive && damageSource.CompareTag("Player"))
                    return;

            float healthBefore = CurrentHealth;
            CurrentHealth -= damage;
            CurrentHealth = Mathf.Clamp(CurrentHealth, 0f, MaxHealth);

            // call OnDamage action
            float trueDamageAmount = healthBefore - CurrentHealth;
            if (trueDamageAmount > 0f)
            {
                OnDamaged?.Invoke(trueDamageAmount, damageSource);
            }

            HandleDeath(damageSource);
        }

        public void Kill()
        {
            CurrentHealth = 0f;

            // call OnDamage action
            OnDamaged?.Invoke(MaxHealth, null);

            HandleDeath(null);
        }

        public PlayerContainer GetPlayer() 
        {
            return gameObject.GetComponent<PlayerContainer>();
        }

        void HandleDeath(GameObject damageSource)
        {
            if(m_IsDead)
                return;

            // call OnDie action
            if (CurrentHealth <= 0f)
            { 
                m_IsDead = true;
                OnDie?.Invoke();

                StartCoroutine(Revive(5));

                if(damageSource != null && damageSource != this.gameObject)
                    damageSource.GetComponent<PlayerContainer>().player.kills++;
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("DeathZone"))
                HandleDeath(null);

        }
    }
}