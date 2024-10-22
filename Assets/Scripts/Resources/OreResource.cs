using UnityEngine.EventSystems;

public class OreResource : AbstractResources
{
    internal override void GiveResources()
    {
        switch (currentPlayerTool) //also using to determine damage to Tree
        {
            case Tools.Fist:
                amount = 0; 
                break;
            case Tools.Pickaxe:
                amount = 1;
                break;
        }
        GameEvents.Current.GiveResourcesToPlayer(resourceType, amount);
    }

    public override void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;
        if (currentHealth <= 0)
            Destroy();
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        GiveResources();
        TakeDamage(amount);
    }
}
