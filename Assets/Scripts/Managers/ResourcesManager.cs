using UnityEngine;

public class ResourcesManager : MonoBehaviour
{
    [SerializeField] private PlayerResourcesScriptableObject playerResources;
    
    void Start()
    { 
        GameEvents.Current.onGiveResourcesToPlayer += GiveResourceToPlayer;
    }
    private void GiveResourceToPlayer(Resources resourceType, int amount)
    {
        switch (resourceType)
        {
            case Resources.Wood:
                playerResources.WoodCount += amount;
                break;
            case Resources.Metal:
                playerResources.MetalCount += amount;
                break;
            case Resources.Money:
                playerResources.MoneyCount += amount;
                break;
        }

        GameEvents.Current.UpdatePlayerResources();
    }
}
