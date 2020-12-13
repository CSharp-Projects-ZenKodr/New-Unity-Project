using Input;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private Vector2 _previousDirection;
        private Vector2 _direction;

        private void Update()
        {
            _direction = InputManager.Controls.Player.Move.ReadValue<Vector2>();

            if (_direction == _previousDirection) return;
            transform.position += new Vector3(Mathf.Ceil(_direction.x), Mathf.Ceil(_direction.y), 0f);
        }

        private void LateUpdate()
        {
            _previousDirection = _direction;
        }
    }
}
