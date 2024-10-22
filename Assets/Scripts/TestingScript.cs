using UnityEngine;
using UnityEngine.EventSystems;

public class TestingScript : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("Left mouse button clicked!");
            
            // Add your code here to perform actions when the left mouse button is clicked
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log("Right mouse button clicked!");
            
            // Add your code here to perform actions when the right mouse button is clicked
        }
    }
}
