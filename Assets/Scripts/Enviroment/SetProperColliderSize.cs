using UnityEngine;

namespace NaughtyAttributes
{
    public class SetProperColliderSize : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer tileSpriteRenderer;
        [SerializeField] private BoxCollider2D tileBoxCollider2D;

        [Button("Set Proper Collider Size")]
        private void SetColliderSize()
        {
            tileBoxCollider2D.size = tileSpriteRenderer.size;
        }
        void Start()
        {
            SetColliderSize();
        }
    }
}

