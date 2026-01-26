using UnityEngine;
using System.Collections;

namespace GMPR2512.Lesson05DeathzoneAndRespawn
{
    public class Deathzone : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPoint;
        void OnTriggerEnter2D(Collider2D collider2D)
        {
            if (collider2D.gameObject.CompareTag("Ball"))
            {
                // wait 2 seconds, respawn the ball at a pre determined spawnpoint
                StartCoroutine(RespawnBall(collider2D.gameObject));
            }
            
        }
        private IEnumerator RespawnBall(GameObject ball)
        {
            Rigidbody2D ballRB = ball.GetComponent<Rigidbody2D>();
            ballRB.linearVelocity = Vector2.zero;
            ballRB.angularVelocity = 0;
            yield return new WaitForSeconds(2);

            ball.transform.position = _spawnPoint.position;
        }   
    }
}
