using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperiencePoints : MonoBehaviour
{
    [SerializeField] private int AmountOfExp;
    private void OnDestroy()
    {
        GameEvents.Current.GiveExperience(AmountOfExp);
    }
}
