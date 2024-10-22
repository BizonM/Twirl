using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] private GameObject defaultStartWeaponPrefab;
    [SerializeField] private GameObject mainWeapon;

    private void Start()
    {
        mainWeapon = defaultStartWeaponPrefab;
        GameObject createdWeapon = Instantiate(mainWeapon, transform);
        
        createdWeapon.transform.localPosition = new Vector2(4f,0);
        createdWeapon.transform.localRotation =Quaternion.identity;
    }
}
