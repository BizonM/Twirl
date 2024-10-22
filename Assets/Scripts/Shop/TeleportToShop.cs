using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class TeleportToShop : MonoBehaviour
{
    [SerializeField]
    private GameObject Shop;

    private void OnTriggerEnter2D(Collider2D info)
    {
        if (info.CompareTag("Player"))
        {
            Vector2 teleportPosition = Shop.transform.position;
            info.transform.position = teleportPosition;
        }
    }
}
