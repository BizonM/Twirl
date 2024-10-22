using UnityEngine;
[CreateAssetMenu (fileName = "PlayerStats" , menuName = "ScriptableObjects/Player/PlayerStats")]
public class PlayerStatsScriptableObject : ScriptableObject
{
    public float CurrentHealth;
    public float MaxHealth;

    public float Level;
    public float CurrentExp;
    public float MaxExp;
    
    public int Damage;
    
    public int MoveSpeed;
    
}
