using System.Collections;
using UnityEngine;

namespace GMPR2512.Lesson07TransformAndInput
{
    public class ArmadaLeader : MonoBehaviour
    {
        [SerializeField] private float _speed = 1.25f;
        private Vector2 _direction = new Vector2(-1, 0);

        internal Vector2 Direction { get => _direction; set => _direction = value; }

        void Update()
        {
            transform.Translate(_direction.normalized * _speed * Time.deltaTime);
        }
    }
}
