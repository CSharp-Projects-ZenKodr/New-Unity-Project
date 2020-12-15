using Input;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private void Update()
        {
            var direction = InputManager.Direction;
            
            Move(direction);
        }

        private void Move(Vector2 direction)
        {
            transform.Translate(direction.x, direction.y, 0f);
        }
    }
}
