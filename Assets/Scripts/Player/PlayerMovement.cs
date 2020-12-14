using Input;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private static Vector2 Direction =>
            new Vector2(
                Mathf.Ceil(InputManager.Controls.Player.Move.ReadValue<Vector2>().x),
                Mathf.Ceil(InputManager.Controls.Player.Move.ReadValue<Vector2>().y));

        private Vector2 _previousDirection;

        private void Update()
        {
            if (Direction == _previousDirection) return;
            Move(Direction);
            
            CorrectPosition();
        }

        private void LateUpdate()
        {
            _previousDirection = Direction;
        }

        private void Move(Vector2 direction)
        {
            transform.Translate(direction.x, direction.y, 0f);
        }

        private void CorrectPosition()
        {
            var position = transform.position;
            position = new Vector3(Mathf.Round(position.x), Mathf.Round(position.y), position.z);
            transform.position = position;
        }
    }
}
