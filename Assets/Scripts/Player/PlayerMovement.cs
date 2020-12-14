using Input;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private Rigidbody2D _rb;
        
        public Vector2 Direction =>
            new Vector2(
                Mathf.Ceil(InputManager.Controls.Player.Move.ReadValue<Vector2>().x),
                Mathf.Ceil(InputManager.Controls.Player.Move.ReadValue<Vector2>().y));

        private Vector2 _previousDirection;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (Direction == _previousDirection) return;
            Move(Direction);
        }

        private void LateUpdate()
        {
            _previousDirection = Direction;
        }

        private void Move(Vector2 direction)
        {
            transform.Translate(direction.x, direction.y, 0f);
        }
    }
}
