using UnityEngine;
using System.Collections;

namespace GMPR2512.Lesson07TransformAndInput
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField] private GameObject _explosionTransform;
        private float _speed = 10, _spinVelocity;
        private Vector2 _direction = Vector2.up;

        internal Vector2 Direction { get => _direction; set => _direction = value; }
        internal float Speed { get => _speed; set => _speed = value; }
        internal float SpinVelocity { set => _spinVelocity = value; }
        void Update()
        {
            transform.Translate(_direction.normalized * _speed * Time.deltaTime, Space.World);
            transform.Rotate(new Vector3(0, 0, _spinVelocity) * Time.deltaTime, Space.World);
        }

        void OnTriggerEnter2D(Collider2D collider2D)
        {
            if(this.gameObject.name == "Projectile(Clone)"){
                if(collider2D.transform.tag.Equals("Alien")){
                    Instantiate(_explosionTransform, collider2D.transform.position, transform.rotation);
                    Destroy(collider2D.gameObject);
                    Destroy(this.gameObject);
                }
            }

            if(this.gameObject.name == "AlienProjectile(Clone)"){
                if(collider2D.transform.tag.Equals("Ship")){
                    Instantiate(_explosionTransform, collider2D.transform.position, transform.rotation);
                    Destroy(collider2D.gameObject);
                    Destroy(this.gameObject);
                }
            } 
            
        }
    }
}
