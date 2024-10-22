using UnityEngine;

public class SimpleWeapon : MonoBehaviour
{
    [SerializeField] private SimpleBullet simpleBulletPrefab;
    [SerializeField] private Transform barrelEnd;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Shoot();
    }

    void Shoot()
    {
        Quaternion parentRotation = transform.parent.rotation;
        SimpleBullet bullet = Instantiate(simpleBulletPrefab, barrelEnd.position, parentRotation);
        bullet.rb.AddForce(transform.right * 50, ForceMode2D.Impulse);
    }
}
