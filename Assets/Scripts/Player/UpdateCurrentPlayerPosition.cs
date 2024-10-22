using UnityEngine;

public class UpdateCurrentPlayerPosition : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Vector2 playerCurrentPosition;

    void Update()
    {
        if (GameEvents.Current.OnUpdatePlayerCurrentPosition != null)
        {
            playerCurrentPosition = playerTransform.position;
            GameEvents.Current.OnUpdatePlayerCurrentPosition(playerCurrentPosition);
        }
    }
}
