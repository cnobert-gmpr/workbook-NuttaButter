using UnityEngine;

namespace GMPR2512.Lesson08ScenesAndUI
{
    [CreateAssetMenu(menuName = "Game State")]
    public class GameState : ScriptableObject
    {
        private int _scoreLevel01 = 0;

        public int ScoreLevel01 { get => _scoreLevel01; set => _scoreLevel01 = value; }

        private void ResetState()
        {
            _scoreLevel01 = 0;
        }

        private void OnEnable()
        {
            ResetState();
        }

        private void OnDisable()
        {
            ResetState();
        }
    }
}