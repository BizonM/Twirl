using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private Vector3 offset;
    void Update()
    {
        cameraTransform.position = playerTransform.position + offset;
    }
}
