using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenDimmer : MonoBehaviour
{
    [SerializeField] private SpriteRenderer dimmerSprite;
    
    public void Awake()
    {
        dimmerSprite.color = Color.clear;
    }
    
}

