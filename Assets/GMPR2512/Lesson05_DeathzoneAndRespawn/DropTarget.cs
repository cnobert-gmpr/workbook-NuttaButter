using UnityEngine;

namespace GMPR2512.Lesson05DeathzoneAndRespawn
{
    public class DropTarget : MonoBehaviour
    {
        [SerializeField] private Color _hitColour = Color.royalBlue;
        [SerializeField] private float _hideDelay = 0.1f, _resetDelay = 2f;
        private bool _isDown = false;
        private SpriteRenderer _renderer;
        private Color _originalColour;

        void Awake()
        {
            _renderer = GetComponent<SpriteRenderer>();
            _originalColour = _renderer.color;
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if(collision.collider.CompareTag("Ball") && !_isDown)
            {
                _isDown = true;
                _renderer.color = _hitColour;
                // Invoke accepts a string. and nameof(method name) is a safe way
                // to pass the string that represents HideTarget
                Invoke(nameof(HideTarget), _hideDelay); // calls HideTarget function in _hideDelay seconds
            }
        }

        void HideTarget()
        {
            this.gameObject.SetActive(false);
            Invoke(nameof(ResetTarget), _resetDelay);
        }

        void ResetTarget()
        {
            _renderer.color = _originalColour;
            gameObject.SetActive(true);
            _isDown = false;
        }
    }
}
