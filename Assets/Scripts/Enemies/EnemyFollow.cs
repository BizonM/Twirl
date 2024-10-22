using System;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] private float movmentSpeed;
    private Vector2 currentPlayerPosition;
    private void Start()
    {
        GameEvents.Current.OnUpdatePlayerCurrentPosition += SetPlayerCurrentPosition;
    }

    private void OnDestroy()
    {
        GameEvents.Current.OnUpdatePlayerCurrentPosition -= SetPlayerCurrentPosition;
    }

    private void FixedUpdate()
    {
        Vector2 newPosition = Vector2.MoveTowards(transform.position, currentPlayerPosition, movmentSpeed);
        transform.position = newPosition;
    }

    private void SetPlayerCurrentPosition(Vector2 playerCurrentPosition)
    {
        currentPlayerPosition = playerCurrentPosition;
    }
}
