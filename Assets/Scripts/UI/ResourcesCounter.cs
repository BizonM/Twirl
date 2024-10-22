using TMPro;
using UnityEngine;

public class ResourcesCounter : MonoBehaviour
{
    [SerializeField] private PlayerResourcesScriptableObject playerResources;
    [SerializeField] private TextMeshProUGUI moneyText;
    [SerializeField] private TextMeshProUGUI woodText;
    [SerializeField] private TextMeshProUGUI metalText;

    private void Start()
    {
        UpdatePlayerResources();
        GameEvents.Current.onUpdatePlayerResources += UpdatePlayerResources;
    }
    
    private void UpdatePlayerResources()
    {
        moneyText.text = "Money: " + playerResources.MoneyCount;
        woodText.text = "Wood: " + playerResources.WoodCount;
        metalText.text = "Metal: " + playerResources.MetalCount;
    }
}
