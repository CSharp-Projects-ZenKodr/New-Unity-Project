using Input;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private Rigidbody2D _rb;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
        
        private void Update()
        {
            var direction = InputManager.Direction;
            
            Move(direction);
        }

        private void Move(Vector2 direction)
        {
            _rb.MovePosition(_rb.position + direction);
        }

        private GameObject GetObjectOnPosition(Vector2 position)
        {
            return null;
        }
    }
}
