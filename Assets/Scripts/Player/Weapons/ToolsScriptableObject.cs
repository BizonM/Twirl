using UnityEngine;
[CreateAssetMenu (fileName = "PlayerToolsAndWeapons" , menuName = "ScriptableObjects/Player/PlayerToolsAndWeapons")]
public class ToolsScriptableObject : ScriptableObject
{
    public Tools CurrentTool;
    public bool haveFist;
    public bool haveAxe;
    public bool havePickaxe;
}
