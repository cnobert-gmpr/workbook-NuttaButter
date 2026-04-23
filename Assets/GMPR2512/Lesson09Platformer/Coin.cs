using UnityEngine;

namespace GMPR2512.Lesson09Platformer
{
    public class Coin : MonoBehaviour
    {
        private SoundHub _soundHub;
        void Awake()
        {
            _soundHub = GameObject.Find("SoundHub").GetComponent<SoundHub>();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            _soundHub.PlayCoinSound();
            Destroy(this.gameObject);
        }
    }
}
