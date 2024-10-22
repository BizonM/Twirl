using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private float healthValue;
    [SerializeField] private Image healthImage;
    [SerializeField] private PlayerStatsScriptableObject playerStats;

    private void Start()
    {
        GameEvents.Current.OnUpdateHealthBar += UpdatePlayerHealthBar;
        UpdatePlayerHealthBar();
    }

    private void OnDestroy()
    {
        GameEvents.Current.OnUpdateHealthBar -= UpdatePlayerHealthBar;
    }

    private void UpdatePlayerHealthBar()
    {
        healthValue = playerStats.CurrentHealth / playerStats.MaxHealth;
        healthImage.fillAmount = healthValue;
    }
}
