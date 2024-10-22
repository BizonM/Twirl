using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsManager : MonoBehaviour
{
    [SerializeField]
    private ToolsScriptableObject toolsScriptableObject;

    private Tools toolToChange;
    void Start()
    { 
        GameEvents.Current.onSetCurrentPlayerTool += SetPlayerTool;
    }

    private void SetPlayerTool(Tools toolToChange)
    {
        toolsScriptableObject.CurrentTool = toolToChange;
    }
}
