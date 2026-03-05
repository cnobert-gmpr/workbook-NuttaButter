using UnityEngine;

namespace GMPR2512.Lesson07TransformAndInput
{
    public class Projectile : MonoBehaviour
    {
        private float _speed = 10, _spinVelocity;
        private Vector2 _direction = Vector2.up;

        internal Vector2 Direction { get => _direction; set => _direction = value; }
        internal float Speed { get => _speed; set => _speed = value;}
        void Update()
        {
            transform.Translate(_direction.normalized * _speed * Time.deltaTime, Space.World);
        }
        
    }
}
