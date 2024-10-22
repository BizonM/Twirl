using UnityEngine.EventSystems;

public class TreeResource : AbstractResources
{
    internal override void GiveResources()
    {
        switch (currentPlayerTool) //also using to determine damage to Tree
        {
            case Tools.Fist:
                amount = 1; 
                break;
            case Tools.Axe:
                amount = 3;
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
