using UnityEngine;

namespace GMPR2512.Lesson06Pinball
{
    public class Flipper : MonoBehaviour
    {
        [SerializeField] private bool _rightFlipper;
        private HingeJoint2D _joint2D;
        void Awake()
        {
            _joint2D = GetComponent<HingeJoint2D>();
        }
        void Update()
        {
            if (_rightFlipper)
            {
                _joint2D.useMotor = Input.GetKey(KeyCode.RightShift);
            } else
            {
                _joint2D.useMotor = Input.GetKey(KeyCode.LeftShift);
            }
            
        }
    }
}
