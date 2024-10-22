using System;
using NaughtyAttributes;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStatsManager : MonoBehaviour
{
    [SerializeField] private PlayerStatsScriptableObject playerStats;
    private void Start()
    {
        GameEvents.Current.OnDealDamageOrHealPlayer += UpdatePlayerHealth;
        GameEvents.Current.OnGiveExperience += UpdatePlayerExperience;
        playerStats.CurrentHealth = playerStats.MaxHealth;
        playerStats.CurrentExp = 0;
        playerStats.MaxExp = 10;
        playerStats.Level = 1;
    }

    private void OnDestroy()
    {
        GameEvents.Current.OnDealDamageOrHealPlayer -= UpdatePlayerHealth;
        GameEvents.Current.OnGiveExperience -= UpdatePlayerExperience;
    }

    private void UpdatePlayerHealth(int amount)
    {
        playerStats.CurrentHealth += amount;
        GameEvents.Current.UpdateHealthBar();

        if (playerStats.CurrentHealth <= 0)
            GameEvents.Current.PlayerDeath();
    }

    private void UpdatePlayerExperience(int amount)
    {
        playerStats.CurrentExp += amount;
        if (playerStats.CurrentExp >= playerStats.MaxExp)
        {
            playerStats.Level += 1;
            playerStats.MaxExp += 5;
            playerStats.CurrentExp = 0;
        }
        GameEvents.Current.UpdateExperienceBar();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Exp"))
            Destroy(other.gameObject);
    }
}
