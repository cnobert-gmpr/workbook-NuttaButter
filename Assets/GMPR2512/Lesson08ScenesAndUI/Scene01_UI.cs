using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

namespace GMPR2512.Lesson08ScenesAndUI
{
    public class Scene01_UI : MonoBehaviour
    {
        private Button _buttonChangeToScene02;

        private void OnEnable()
        {
            VisualElement root = GetComponent<UIDocument>().rootVisualElement;
            _buttonChangeToScene02 = root.Q<Button>("ChangeToScene02Button");
            if(_buttonChangeToScene02 != null)
            {
                _buttonChangeToScene02.clicked += ChangeToScene02;
            }
        }

        private void OnDisable()
        {
            if(_buttonChangeToScene02 != null)
            {
                _buttonChangeToScene02.clicked -= ChangeToScene02;
            }
        }

        private void ChangeToScene02()
        {
            // scenes can be added to scene list through
            // file > build profiles > open scene list
            SceneManager.LoadScene(2);
        }
    }
}
