using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents Current;

    private void Awake()
    {
        Current = this;
    }

    public Action<Vector2> OnUpdatePlayerCurrentPosition;
    public Action<int> OnDealDamageOrHealPlayer;
    public Action OnUpdateHealthBar;
    public Action OnPlayerDeath;
    public Action<int> OnGiveExperience;
    public Action OnUpdateExperienceBar;

    public void UpdateExperienceBar()
    {
        OnUpdateExperienceBar?.Invoke();
    }
    
    public void UpdatePlayerCurrentPosition(Vector2 position)
    {
        OnUpdatePlayerCurrentPosition?.Invoke(position);
    }
    public void DealDamageOrHealPlayer(int health)
    {
        OnDealDamageOrHealPlayer?.Invoke(health);
    }
    public void UpdateHealthBar()
    {
        OnUpdateHealthBar?.Invoke();
    }
    public void PlayerDeath()
    {
        OnPlayerDeath?.Invoke();
    }

    public void GiveExperience(int amount)
    {
        OnGiveExperience?.Invoke(amount);
    }
    // Old Game type (Maybe delete later)
    
    public Action onUpdatePlayerResources;
    public Action<Resources, int> onGiveResourcesToPlayer;
    public Action<Tools> onSetCurrentPlayerTool; 
    

    public void UpdatePlayerResources()
    {
        onUpdatePlayerResources?.Invoke();
    }

    public void GiveResourcesToPlayer(Resources resourcesType, int amount)
    {
        onGiveResourcesToPlayer?.Invoke(resourcesType, amount);
    }

    public void SetCurrentPlayerTool(Tools currentTool)
    {
        onSetCurrentPlayerTool?.Invoke(currentTool);
    }
    
}
