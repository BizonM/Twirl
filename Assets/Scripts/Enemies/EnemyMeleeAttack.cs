using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyMeleeAttack : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private bool isAbleToAttack;
    [SerializeField] private ExperiencePoints Exp;
    private bool isInsidePlayer;
    

    private void DealDamageToPlayer()
    {
        GameEvents.Current.DealDamageOrHealPlayer(-damage);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && isAbleToAttack)
        {
            isInsidePlayer = true;
            DealDamageToPlayer();
            StartCoroutine(StayInsideCoroutine());
            StartCoroutine(DelayBetweenAttacks());
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            isInsidePlayer = false;
    }

    private void OnDestroy()
    {
        Instantiate(Exp, gameObject.transform.position, quaternion.identity);
    }

    private IEnumerator StayInsideCoroutine()
    {
        while (isInsidePlayer)
        {
            yield return new WaitForSeconds(1f);
                if(isInsidePlayer)
                    DealDamageToPlayer();
        }
    }

    private IEnumerator DelayBetweenAttacks()
    {
        isAbleToAttack = false;
        yield return new WaitForSeconds(1f);
        isAbleToAttack = true;
    }
}
