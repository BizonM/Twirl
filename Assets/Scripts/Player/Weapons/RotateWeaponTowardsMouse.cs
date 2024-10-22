using UnityEngine;

public class RotateWeaponTowardsMouse : MonoBehaviour
{
    private void Update()
    {
        RotateTowardsMouse();
    }
    
    private void RotateTowardsMouse()
    {
        Vector2 targetPositionToRotateAround = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mouseDirection = mousePosition - targetPositionToRotateAround;

        float angle = Mathf.Atan2(mouseDirection.y, mouseDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0,0,angle));
        
        if (angle <= -90f || angle >= 90f)
            transform.localScale = new Vector2(1,-1);
        else
            transform.localScale = new Vector2(1,1);
    }
}
