using UnityEngine;

namespace GMPR2512.Lesson09Platformer
{
    public class SoundHub : MonoBehaviour
    {
        private AudioSource[] _sources;
        void Awake()
        {
            _sources = GetComponents<AudioSource>();
        }

        public void PlayCoinSound()
        {
            _sources[0]?.Play();
        }
    }
}
