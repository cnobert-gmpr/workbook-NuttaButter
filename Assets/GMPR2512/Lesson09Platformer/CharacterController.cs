using UnityEngine;

namespace GMPR2512.Lesson09Platformer
{
    public class CharacterController : MonoBehaviour
    {
        public float _maxSpeed = 5;
        public Transform _groundCheck;
        public float _jumpForce = 1000;

        protected Animator _myAnimator;
        protected Rigidbody2D _myRigidBody;
        protected float _moveForce = 365;
        protected bool _facingRight = true;
        protected bool _grounded = false;
        protected bool _jump = false;

        void Awake()
        {
            _myAnimator = GetComponent<Animator>();
            _myRigidBody = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            //_grounded will be true if our hero is standing on a platform (remember to add the platform to the ground layer)
            //layer mask bitwise ops: https://answers.unity.com/questions/8715/how-do-i-use-layermasks.html
            _grounded = Physics2D.Linecast(transform.position, _groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
            if (Input.GetButtonDown("Jump") && _grounded)
            {
                _jump = true;
            }
        }

        void FixedUpdate()
        {
            float horizontalAxis = Input.GetAxis("Horizontal");
            _myAnimator.SetFloat("Speed", Mathf.Abs(horizontalAxis));

            //Have we reached maxSpeed? If not, add force.
            if (horizontalAxis * _myRigidBody.linearVelocity.x < _maxSpeed)
            {
                _myRigidBody.AddForce(Vector2.right * horizontalAxis * _moveForce);
            }

            //Have we exceeded the maxSpeed? Clamp it.
            if (Mathf.Abs(_myRigidBody.linearVelocity.x) > _maxSpeed)
            {
                _myRigidBody.linearVelocity = new Vector2(
                    Mathf.Sign(_myRigidBody.linearVelocity.x) * _maxSpeed,
                    _myRigidBody.linearVelocity.y
                );
            }

            if (_jump)
            {
                _myAnimator.SetTrigger("Jump");
                _myRigidBody.AddForce(new Vector2(0, _jumpForce));
                _jump = false;
            }
        }
    }
}
