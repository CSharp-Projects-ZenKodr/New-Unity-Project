using UnityEngine;

namespace Blocks
{
    public class Block : MonoBehaviour
    {
        private Rigidbody2D _rb;
        
        public Vector2 Position { get; set; }

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
        
        private void Update()
        {
            var pos = new Vector3(Position.x, Position.y, 0f);

            if (transform.position != pos) transform.position = pos;
        }

        public void Move(Vector2 direction)
        {
            transform.Translate(direction);
        }
    }
}
