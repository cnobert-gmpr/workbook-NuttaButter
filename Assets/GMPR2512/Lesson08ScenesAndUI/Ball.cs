using UnityEngine;

namespace GMPR2512.Lesson08ScenesAndUI
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private GameState _gameState;

        void OnCollisionEnter2D(Collision2D collision)
        {
            _gameState.ScoreLevel01++;
        }
    }
}