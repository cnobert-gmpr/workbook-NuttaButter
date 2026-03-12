using UnityEngine;

namespace GMPR2512.Lesson07TransformAndInput
{
    public class Alien : MonoBehaviour
    {
        [SerializeField] private float _projectileSpeed = 5, _projectileSpinVelocity = -2000;
        [SerializeField] private GameObject _projectilePrefab;
        [SerializeField] private int _upperRandomFiringRange;
        void Update()
        {
            int rando = Random.Range(1, _upperRandomFiringRange);
            if(rando == 1)
            {
                Vector3 firingPosition = transform.GetChild(0).position;
                GameObject theProjectile = Instantiate(_projectilePrefab, firingPosition, transform.rotation);
                Projectile projectileScript = theProjectile.GetComponent<Projectile>();
                projectileScript.Speed = _projectileSpeed;
                projectileScript.Direction = transform.up;
                projectileScript.SpinVelocity = _projectileSpinVelocity;

            }
        }

        void OnTriggerEnter2D(Collider2D collider)
        {
            if(collider.gameObject.name == "LeftWall" || collider.gameObject.name == "RightWall")
            {
                ArmadaLeader leaderScript = transform.parent.GetComponent<ArmadaLeader>();
                leaderScript.Direction *= -1;
            }
            
        }
    }
}
