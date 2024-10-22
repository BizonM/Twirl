using System;
using UnityEngine;
using UnityEngine.EventSystems;


public abstract class AbstractResources : MonoBehaviour, IDamagable, IPointerClickHandler
{
    [SerializeField] internal int maxHealth;
    [SerializeField] internal int currentHealth;
    [SerializeField] internal Resources resourceType;
    [SerializeField] internal Tools currentPlayerTool;
    internal int amount;

    private void Start()
    {
        currentPlayerTool = Tools.Fist;
        GameEvents.Current.onSetCurrentPlayerTool += SetPlayerTool;
        currentHealth = maxHealth;
    }

    private void OnDestroy()
    {
        GameEvents.Current.onSetCurrentPlayerTool -= SetPlayerTool;
    }

    internal void SetPlayerTool(Tools setTool)
    {
        currentPlayerTool = setTool;
    }
    internal abstract void GiveResources();
    public abstract void OnPointerClick(PointerEventData eventData);
    public abstract void TakeDamage(int damageTaken);

    public void Destroy()
    {
        gameObject.SetActive(false);
    }
}

